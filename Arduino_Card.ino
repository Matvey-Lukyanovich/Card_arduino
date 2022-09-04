 // Видеообзоры и уроки работы с ARDUINO на YouTube-канале IOMOIO: https://www.youtube.com/channel/UCmNXABaTjX_iKH28TTJpiqA

/*
 * -----------------------------------------------------------------------------------------
 *             MFRC522      Arduino       Arduino   Arduino    Arduino          Arduino
 *             Reader/PCD   Uno/101       Mega      Nano v3    Leonardo/Micro   Pro Micro
 * Signal      Pin          Pin           Pin       Pin        Pin              Pin
 * -----------------------------------------------------------------------------------------
 * RST/Reset   RST          9             5         D9         RESET/ICSP-5     RST
 * SPI SS      SDA(SS)      10            53        D10        10               10
 * SPI MOSI    MOSI         11 / ICSP-4   51        D11        ICSP-4           16
 * SPI MISO    MISO         12 / ICSP-1   50        D12        ICSP-1           14
 * SPI SCK     SCK          13 / ICSP-3   52        D13        ICSP-3           15
 * -----------------------------------------------------------------------------------------
 */

#include <MFRC522.h>               // Подключаем библиотеку для работы с модулем RC522

#define RST_PIN         9          // Пин подключения вывода RST модуля
#define SS_PIN          10         // Пин подключения SDA(SS) вывода модуля

MFRC522 mfrc522(SS_PIN, RST_PIN);  // Создаем объект для работы с библиотекой MFRC522 и сообщаем ей пины подключения модуля

void setup() {
	Serial.begin(9600);		                                      // Инициализируем вывод данных на монитор серийного порта
	while (!Serial);		                                        // Ждем пока не инициализируется монитор серийного порта
	SPI.begin();			                                          // Инициализируем интерфейс SPI
	mfrc522.PCD_Init();		                                      // Инициализируем модуль MFRC522
  mfrc522.PCD_DumpVersionToSerial();	                        // Выводим версию прошивки модуля на монитор серийного порта
	Serial.println("Please, place RFID-label over the reader"); // Выводим сообщение о том, что модуль готов к считыванию и ожидает метку
}

void loop() {
// Ожидаем метку
	if (!mfrc522.PICC_IsNewCardPresent())       // Если метка не обнаружена, то
		return;                                   //  прерываем исполнение текущей петли (loop)

// Пытаемся прочитать метку
	if (!mfrc522.PICC_ReadCardSerial())         // Если не получается считать UID карты, то
		return;                                   //  прерываем исполнение текущей петли (loop)
                                              // в ином случае заполняется структура uid, которая используется в качестве аргумента в следующей строке данного скетча
                                              
  String content= "";
  byte letter;
  for (byte i = 0; i < mfrc522.uid.size; i++) 
  {

     content.concat(String(mfrc522.uid.uidByte[i] < 0x10 ? " 0" : " "));
     content.concat(String(mfrc522.uid.uidByte[i], HEX));
  }


  content.toUpperCase();
  Serial.println (content); // Пишем в консоль код карты
  delay(1500);
  
	//mfrc522.PICC_DumpToSerial(&(mfrc522.uid));  // Выводим информацию о метке и считанную с нее информацию в монитор серийного порта
}
