///////////////////////////////////////////////////////////////////////////////////////////////////
//
// $Workfile: DrvAIO.h $
//
// Description: This file defines the interface (API) of this driver (Exported symbols of the DLL).
//				DrvAIO is a driver for ..... TBD ....
//
//			
//				
// How to Use:	In order to use this driver, first call the DrvAIO_InitDriver() function, with
//				the name of the INI file (NULL or "" can be used for minimal Init).
//				The Init function can be called several times, it is protected.
//				After that, you may Add/Remove devices, and manipulate them udSineWaveg the API functions
//				or the GUI of the driver.
//
//  INI File Example (copy until ';')
//  ================
//
//	[DrvAIO.General]
//	PanelsPositionsFile = C:\ATEs\RATE\Config\PanelsPositions.INI
//	DevicesThread_StackSize = 250000	  							; stack size in bytes
//	MainPanelThread_StackSize = 250000	  							; stack size in bytes 
//
//
//	[DrvAIO.Dev.ExampleDev1]
//	sConnectionString = Example Connection String [eg:MIO1]
//	eDevType = 1
//	bSimulation = 0
//	bResetDevice = 1
//	bReadOnly = 0 													; is the device in read only state
//	bIgnoreATEDisplay = 0											; do not add frame for device in 'ATE_Display.INI' 
//  bLoadInThread = 0												; loads the device in thread (to speedup init process)
//	bIgnoreLoadDevice = 0											; signals the generic ATE dll NOT to load this device during the ATE powerup function.
//	sPartName = "DEV1"												; indicates the device's part name (should be consistent to the part name in the ATEDisplay.INI  Eg: sPartName = ExampleDev1)
// 
///////////////////////////////////////////////////////////////////////////////////////////////////
//=================================================================================================
//								Device Types Definition
//=================================================================================================
#if !defined(_DRV_AIO_DEV_TYPE_STRINGS_ONLY_) && !defined(DRV_AIO_H)
	// this is the "regular" h file (exported enums) 
	#define ITEM(eNum , sName )		eNum ,
	typedef enum
		{
#else
 #ifdef _DRV_AIO_DEV_TYPE_STRINGS_ONLY_
	#define ITEM(eNum , sName )		sName ,
	const char*	g_asDevTypes[] = 
		{
 #endif
#endif
	// Device Types Definitions - start
	ITEM(	DRV_AIO_DEV_TYPE_NONE 			=0	,"NONE"			)   // always NONE=0  first    // the =X is optional !!! 
	ITEM(	DRV_AIO_DEV_TYPE_NI_6071			,"NI_6071"				)  
	ITEM(	DRV_AIO_DEV_TYPE_NI_6221			,"NI_6221"				)
	ITEM(	DRV_AIO_DEV_TYPE_NI_6704			,"NI_6704"				)
	ITEM(	DRV_AIO_DEV_TYPE_NI_6229			,"NI_6229"				)
	ITEM(	DRV_AIO_DEV_TYPE_NI_6723			,"NI_6723"				)
	ITEM(	DRV_AIO_DEV_TYPE_NI_6225			,"NI_6225"				)
	ITEM(	DRV_AIO_DEV_TYPE_NI_6255			,"NI_6255"				)
	ITEM(	DRV_AIO_DEV_TYPE_NI_6259			,"NI_6259"				) 
	ITEM(	DRV_AIO_DEV_TYPE_NI_6341			,"NI_6341"				)
	ITEM(	DRV_AIO_DEV_TYPE_NI_6363			,"NI_6363"				)
	ITEM(	DRV_AIO_DEV_TYPE_DENKOVI_DAENETIP2	,"DENKOVI_DAENETIP2"	)
	ITEM(	DRV_AIO_DEV_TYPE_NI_600x			,"NI_600x"				)
	ITEM(	DRV_AIO_DEV_TYPE_NI_6321			,"NI_6321"				)
	
	ITEM(	DRV_AIO_DEV_TYPE_MAX				,""				)	// always MAX last
	// Device Types Definitions - finish
		
#if !defined(_DRV_AIO_DEV_TYPE_STRINGS_ONLY_) && !defined(DRV_AIO_H)
		} DRV_AIO_DEV_TYPE_T ;
#else
 #ifdef _DRV_AIO_DEV_TYPE_STRINGS_ONLY_
		} ;	
 #undef _DRV_AIO_DEV_TYPE_STRINGS_ONLY_
 #endif
#endif
#undef ITEM

	
	
	
//=================================================================================================
//							Start of "Regular" include file
//=================================================================================================
#ifndef DRV_AIO_H
#define DRV_AIO_H

//=================================================================================================
//										Includes
//=================================================================================================
// standard libraries (exported)
#include <windows.h>

#ifdef __cplusplus
extern "C" {
#endif	



//=================================================================================================
//									   Types Definition
//=================================================================================================




typedef enum 
{
	DRV_AIO_CHANNELS_TERMINATOR = -1,
	DRV_AIO_AI_CHANNELS_CH0, DRV_AIO_AI_CHANNELS_CH1,	DRV_AIO_AI_CHANNELS_CH2, DRV_AIO_AI_CHANNELS_CH3,	DRV_AIO_AI_CHANNELS_CH4, DRV_AIO_AI_CHANNELS_CH5, DRV_AIO_AI_CHANNELS_CH6, DRV_AIO_AI_CHANNELS_CH7, DRV_AIO_AI_CHANNELS_CH8, DRV_AIO_AI_CHANNELS_CH9,
	DRV_AIO_AI_CHANNELS_CH10, DRV_AIO_AI_CHANNELS_CH11, DRV_AIO_AI_CHANNELS_CH12, DRV_AIO_AI_CHANNELS_CH13,	DRV_AIO_AI_CHANNELS_CH14, DRV_AIO_AI_CHANNELS_CH15, DRV_AIO_AI_CHANNELS_CH16, DRV_AIO_AI_CHANNELS_CH17, DRV_AIO_AI_CHANNELS_CH18, DRV_AIO_AI_CHANNELS_CH19,
	DRV_AIO_AI_CHANNELS_CH20, DRV_AIO_AI_CHANNELS_CH21, DRV_AIO_AI_CHANNELS_CH22, DRV_AIO_AI_CHANNELS_CH23, DRV_AIO_AI_CHANNELS_CH24, DRV_AIO_AI_CHANNELS_CH25, DRV_AIO_AI_CHANNELS_CH26, DRV_AIO_AI_CHANNELS_CH27, DRV_AIO_AI_CHANNELS_CH28, DRV_AIO_AI_CHANNELS_CH29,
	DRV_AIO_AI_CHANNELS_CH30, DRV_AIO_AI_CHANNELS_CH31, DRV_AIO_AI_CHANNELS_CH32, DRV_AIO_AI_CHANNELS_CH33,	DRV_AIO_AI_CHANNELS_CH34, DRV_AIO_AI_CHANNELS_CH35, DRV_AIO_AI_CHANNELS_CH36, DRV_AIO_AI_CHANNELS_CH37, DRV_AIO_AI_CHANNELS_CH38, DRV_AIO_AI_CHANNELS_CH39,
	DRV_AIO_AI_CHANNELS_CH40, DRV_AIO_AI_CHANNELS_CH41, DRV_AIO_AI_CHANNELS_CH42, DRV_AIO_AI_CHANNELS_CH43,	DRV_AIO_AI_CHANNELS_CH44, DRV_AIO_AI_CHANNELS_CH45, DRV_AIO_AI_CHANNELS_CH46, DRV_AIO_AI_CHANNELS_CH47, DRV_AIO_AI_CHANNELS_CH48, DRV_AIO_AI_CHANNELS_CH49,
	DRV_AIO_AI_CHANNELS_CH50, DRV_AIO_AI_CHANNELS_CH51, DRV_AIO_AI_CHANNELS_CH52, DRV_AIO_AI_CHANNELS_CH53,	DRV_AIO_AI_CHANNELS_CH54, DRV_AIO_AI_CHANNELS_CH55, DRV_AIO_AI_CHANNELS_CH56, DRV_AIO_AI_CHANNELS_CH57, DRV_AIO_AI_CHANNELS_CH58, DRV_AIO_AI_CHANNELS_CH59,
	DRV_AIO_AI_CHANNELS_CH60, DRV_AIO_AI_CHANNELS_CH61, DRV_AIO_AI_CHANNELS_CH62, DRV_AIO_AI_CHANNELS_CH63,	DRV_AIO_AI_CHANNELS_CH64, DRV_AIO_AI_CHANNELS_CH65, DRV_AIO_AI_CHANNELS_CH66, DRV_AIO_AI_CHANNELS_CH67, DRV_AIO_AI_CHANNELS_CH68, DRV_AIO_AI_CHANNELS_CH69,
	DRV_AIO_AI_CHANNELS_CH70, DRV_AIO_AI_CHANNELS_CH71, DRV_AIO_AI_CHANNELS_CH72, DRV_AIO_AI_CHANNELS_CH73,	DRV_AIO_AI_CHANNELS_CH74, DRV_AIO_AI_CHANNELS_CH75, DRV_AIO_AI_CHANNELS_CH76, DRV_AIO_AI_CHANNELS_CH77, DRV_AIO_AI_CHANNELS_CH78, DRV_AIO_AI_CHANNELS_CH79,
	
}DRV_AIO_AI_CHANNELS_EN ; ;

typedef enum 
{
	DRV_AIO_AO_CHANNELS_CH0, DRV_AO_CHANNELS_CH1,	
	
}DRV_AIO_AO_CHANNELS_EN ;

typedef enum
{
	DRV_AIO_CHANNEL_CONFIG_DIFF ,
	DRV_AIO_CHANNEL_CONFIG_RSE ,
	DRV_AIO_CHANNEL_CONFIG_NRSE 

}DRV_AIO_CHANNEL_CONFIG_EN;


typedef enum
{
 	DRV_AIO_IDLE_IDLE_STSTE_VAL_LOW,
	DRV_AIO_IDLE_IDLE_STSTE_VAL_HIGH
	
}DRV_AIO_IDLE_STSTE_EN;

typedef enum
{
 	DRV_AIO_SAMPLE_FINITE,
	DRV_AIO_SAMPLE_CONT,
	DRV_AIO_SAMPLE_HWTimedSinglePoint
	
}DRV_AIO_SAMPLE_MODE;

typedef enum
{
 	DRV_AIO_TRAP_EVENT_RESPONSE_NONE,
	DRV_AIO_TRAP_EVENT_RESPONSE_SET_LOW,
	DRV_AIO_TRAP_EVENT_RESPONSE_SET_HIGH,
	DRV_AIO_TRAP_EVENT_RESPONSE_SET_LOW_HIGH,
	DRV_AIO_TRAP_EVENT_RESPONSE_SET_ACC,
	
}DRV_AIO_TRAP_EVENT_RESPONSE_ENUM;


//=================================================================================================
//								External Globals Declerations
//=================================================================================================




//=================================================================================================
//									MACROs Definition
//=================================================================================================

// GUI States - used with DrvAIO_SetGUIState()
#ifndef GUI_STATE_NORMAL
 #define GUI_STATE_NORMAL 				0
 #define GUI_STATE_MINIMIZED 			1
 #define GUI_STATE_MINIMIZED_TO_ICON 	2
 #define GUI_STATE_MAXIMIZED 			3
 #define GUI_STATE_HIDDEN 				4
#endif




//=================================================================================================
//									Function Declerations
//=================================================================================================

// Driver
int 	__stdcall 	DrvAIO_InitDriver 			    ( char sInitFile[] ) ;
void 	__stdcall 	DrvAIO_CloseDriver 			    ( void ) ;
void	__stdcall	DrvAIO_WaitForMainQuit		    ( void ) ; // runs till the QUIT is pressed and finished (used only for the EXE panel)
int		__stdcall	DrvAIO_GetNumberOfDevices	    ( void ) ;
void	__stdcall	DrvAIO_SetMainPanelState	    ( int iGuiState ) ; // GUI_STATE_...NORMAL/MINIMIZED/MINIMIZED_TO_ICON/MAXIMIZED/HIDDEN
void	__stdcall	DrvAIO_SetPanelsBackColor	    ( unsigned int uColor ) ; 
int 	__stdcall	DrvAIO_GetDriverVersion 	    ( char *psVersion , int* piMajor , int* piMinor , int* piBuild ) ; // XX.YY (Build ZZZZ)
void 	__stdcall 	DrvAIO_SetToCloseDriverOnQuit   ( void ) ;

int 	__stdcall 	DrvAIO_GetDefaultDriversINIFile ( char *psDriversINI, int iBufferLength ) ; // used in DrvAIO_Panel.exe // Added since V2.0.0
int		__stdcall	DrvAIO_GetLogState 				( void ) ;			// Added since V2.0.0
void 	__stdcall	DrvAIO_SetLogState 				( int iLogState ) ; // LOG_STATE_...NONE/DEBUG/MESSAGE/WARN/ERROR/COMMAND/START_STOP_FUNCTION/ALL (must include "LoggerClientCVI_Exports.h") // Added since V2.0.0
BOOL 	__stdcall 	DrvAIO_GetFrequenciesVisible 	( void ) ; // Added since V2.0.0
void 	__stdcall 	DrvAIO_SetFrequenciesVisible 	( BOOL bShowFreq )  ; // Added since V2.0.0
BOOL	__stdcall	DrvAIO_GetIsDriverInitialized   ( void );

// Device
int		__stdcall	DrvAIO_AddDevice			    ( char sDevName[], char sConnectionString[], DRV_AIO_DEV_TYPE_T eDevType, BOOL bSimulation, BOOL bResetDevice) ;
int		__stdcall	DrvAIO_AddDeviceFromFile	    ( char sDevName[], char sInitFile[] ) ; 	
int		__stdcall	DrvAIO_AddDevicesFromFile	    ( char sInitFile[] ) ; 	
int		__stdcall	DrvAIO_CloseDevice			    ( char sDevName[] ) ;
void	__stdcall	DrvAIO_CloseAllDevices		    ( void ) ;
int		__stdcall 	DrvAIO_ReInitDevice				( char sDevName[] , BOOL bResetDevice );      

int		__stdcall	DrvAIO_GetDevType			    ( char sDevName[] ) ;
void	__stdcall	DrvAIO_GetDevConnectionString	( char sDevName[], char* psConnectionString ) ;
BOOL	__stdcall	DrvAIO_GetSimulation		    ( char sDevName[] ) ;
int		__stdcall	DrvAIO_SelfTest			        ( char sDevName[] ) ;
int		__stdcall	DrvAIO_Reset				    ( char sDevName[] ) ;
int		__stdcall	DrvAIO_GetDeviceError		    ( char sDevName[] , int* piErrorCode, char* psErrorString , char* psErrorLongDescription ) ;
long	__stdcall	DrvAIO_GetDeviceHandle		    ( char sDevName[] ) ;

void	__stdcall	DrvAIO_SetGuiReadOnly		    ( BOOL bReadOnly ) ;
BOOL	__stdcall	DrvAIO_GetGuiReadonly		    ( void ) ;

void	__stdcall	DrvAIO_SetDevicePanelState	    ( char sDevName[], int iGuiState ) ; // NORMAL/MINIMIZED/MINIMIZED_TO_ICON/MAXIMIZED/HIDDEN
int		__stdcall	DrvAIO_GetDevicePanelState	    ( char sDevName[] ) ; // NORMAL/MINIMIZED/MINIMIZED_TO_ICON/MAXIMIZED/HIDDEN
void	__stdcall	DrvAIO_HideAll				    ( void ) ;
void	__stdcall	DrvAIO_MinimizeAll			    ( void ) ;
void	__stdcall	DrvAIO_ShowAll				    ( void ) ;
void	__stdcall	DrvAIO_DockAll				    ( void ) ;
void	__stdcall	DrvAIO_UnDockAll			    ( void ) ;

void	__stdcall	DrvAIO_SetPanelUpdateRate	    ( char sDevName[], int iIntervalmSec ) ; // -1=Manual 0..
int		__stdcall	DrvAIO_GetPanelUpdateRate	    ( char sDevName[] ) ; // -1=Manual 0..
void  	__stdcall	DrvAIO_UpdateDevicePanel	    ( char sDevName[] ) ;


// Specific Driver Functions
// AOutput function
//-----------------------------------------------------------------------------------------------   

int     __stdcall   DrvAIO_ConfigAOChannel       ( char sDevName[],int iChannelNumber , double dWaveformArr[],
											       int iSizeOfArr, double dSamplesPerSec ,DRV_AIO_SAMPLE_MODE enSampleMode );

int     __stdcall   DrvAIO_ConfigMultipleAOChannels( char sDevName[],int* paiChannels, int iNumOfChannels, double adChannelsWaveformArr[]/*grouped by Channel*/,
											 int iSamplesPerChannel, double dSamplePerSec ,DRV_AIO_SAMPLE_MODE enSampleMode );

int     __stdcall   DrvAIO_StartAOChannel        ( char sDevName[] , int iChannelNumber); //For multiple channels choose any channel from the group

int     __stdcall   DrvAIO_StopAOChannel         ( char sDevName[],   int iChannelNumber);

int     __stdcall   DrvAIO_ClearAOChannel        ( char sDevName[],  int iChannelNumber);

int     __stdcall   DrvAIO_SetAOChannelVoltage   ( char sDevName[],int iChannelNumber , 
												   double dVoltage );

// AIutput function
//-----------------------------------------------------------------------------------------------   

int     __stdcall  	DrvAIO_ConfigAIOChannel       ( char sDevName[],int iChannelNumber ,
												   DRV_AIO_CHANNEL_CONFIG_EN enChannelConfig ,
												   double dSamplePerSec ,int iBufferSize);
int     __stdcall  	DrvAIO_ConfigMultipleAIOChannels( char sDevName[],int* paiChannels, int iNumOfChannels, DRV_AIO_CHANNEL_CONFIG_EN enChannelConfig ,
														double dSamplePerSec , int iBufferSize);


int     __stdcall  	DrvAIO_StartAIOChannel        	( char sDevName[] , int iChannelNumber);  //For multiple channels choose any channel from the group



int     __stdcall	DrvAIO_GetAIOChannelVoltage   ( char sDevName[],int iChannelNumber ,
												   DRV_AIO_CHANNEL_CONFIG_EN enChannelConfig, 
												   double* dVoltage  );

int     __stdcall   DrvAIO_GetAIOBuffer          ( char sDevName[] , int iChannelNumber ,double dReadDataArr[] ,
												   int iSizeOfArr);


//			---AI Data aquire NOT in thread
int     __stdcall  	DrvAIO_StartAquiring        	( char sDevName[] , int iChannelNumber);    // Start samples aquiring process without trying to read the samples.
																								// Use  DrvAIO_RetrieveAIBuffer to get available samples
																								// For multiple channels choose any channel from the group

int     __stdcall   DrvAIO_RetrieveAIBuffer      ( 												// Retrieve available AI buffer 
													char sDevName[] ,
													int iChannelNumber ,						//channel number to aqcuire its samples 
													double dReadDataArr[] ,						//array of samples
												   	int iSizeOfArr,								//size of  dReadDataArr array
													int* iNumberOfAcquiredSamples);				//OUT: number of samples acquired from the previouse call untill now and placed in dReadDataArr

int     __stdcall  	DrvAIO_StopAquiring        	( char sDevName[] , int iChannelNumber);		//stop Aquiring process initiated with   DrvAIO_StartAquiring(..) 


//---------------------------------------------------------------------------------------------   


int     __stdcall 	DrvAIO_GetNumberOfChannels	( char sDevName[],char* sChannelsList , PUINT puiNoOfChannels);
										

//---------------------------------------------------------------------------------------------   

int     __stdcall 	DrvAIO_GeneratePulseClock	(char sDevName[],char* sListOfChannels ,double	dFrequncy,
												 double dDutyCycle, ULONG ulIdleState , BOOL bStart);

int     __stdcall 	DrvAIO_SetPulseClockChannel	( char sDevName[],char* sListOfChannels ,double dFrequncy,
												  double dDutyCycle, ULONG ulIdleState , BOOL bGenerate);
//Set sDevName &  sListOfChannels , Set other  params to FALSE for dismissing the clock channel

int    __stdcall 	DrvAIO_SetPulseClock		( char sDevName[], BOOL bClockStart);

//Traps Functions
//---------------------------------------------------------------------------------------------   
int    __stdcall 	DrvAIO_SetTrap				( char sDevName[], int iAI_ChannelNumber , double dLowThreshold_Voltage , 
													double dHighThreshold_Voltage , DRV_AIO_TRAP_EVENT_RESPONSE_ENUM enEventResponse ) ;

int    __stdcall 	DrvAIO_GetTrap				( char sDevName[], int iAI_ChannelNumber , double * dLowThreshold_Voltage , 
													double * dHighThreshold_Voltage , DRV_AIO_TRAP_EVENT_RESPONSE_ENUM * enEventResponse ) ;

//=================================================================================================
//		  						 End of Function Declerations
//=================================================================================================

#ifdef __cplusplus
}
#endif

#endif // DRV_AIO_H
