///////////////////////////////////////////////////////////////////////////////////////////////////
//
// $Workfile: DrvPS.h $
//
// Description: This file defines the interface (API) of this driver (Exported symbols of the DLL).
//				DrvPS is a driver for General Power supplies
//
//			
//				
// How to Use:	In order to use this driver, first call the DrvPS_InitDriver() function, with
//				the name of the INI file (NULL or "" can be used for minimal Init).
//				The Init function can be called several times, it is protected.
//				After that, you may Add/Remove devices, and manipulate them using the API functions
//				or the GUI of the driver.
//
// 	Added since V2.0.0
//  INI File Example (copy until ';')
//  ================
//
//	[DrvPS.General]
//	PanelsPositionsFile = C:\ATEs\RATE\Config\PanelsPositions.INI
//	DevicesThread_StackSize = 250000	  							; stack size in bytes
//	MainPanelThread_StackSize = 250000	  							; stack size in bytes 
//
//  // TBD: add some examples for connection string
//	[DrvPS.Dev.ExampleDev1]
//	sConnectionString = GPIB0::1::INSTR[Addr:2][BaudRate:9600]
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
#if !defined(_DRV_PS_DEV_TYPE_STRINGS_ONLY_) && !defined(DRV_PS_H)
	// this is the "regular" h file (exported enums) 
	#define ITEM(eNum , sName )		eNum ,
	typedef enum
		{
#else
 #ifdef _DRV_PS_DEV_TYPE_STRINGS_ONLY_
	#define ITEM(eNum , sName )		sName ,
	const char*	g_asDevTypes[] = 
		{
 #endif
#endif
	// Device Types Definitions - start
	ITEM(	DRV_PS_DEV_TYPE_NONE 				=0	 ,"NONE"				     )   // always NONE=0  first  // the =X is optional !!!
	ITEM(	DRV_PS_DEV_TYPE_LAMBDA_ZUP				 ,"LAMBDA_ZUP"		    	 )   
	ITEM(	DRV_PS_DEV_TYPE_LAMBDA_GENESYS		  	 ,"LAMBDA_GENESYS"	    	 )
	ITEM(	DRV_PS_DEV_TYPE_SORENSEN			 	 ,"SORENSEN"			   	 )
	ITEM(	DRV_PS_DEV_TYPE_LAMBDA_GENESYS_GPIB		 ,"LAMBDA_GENESYS_GPIB"	     )
	ITEM(	DRV_PS_DEV_TYPE_PICKERING_41_742_001     ,"PICKERING_41_742_001"     )
	ITEM(	DRV_PS_DEV_TYPE_LAMBDA_GENESYS_LAN		 ,"LAMBDA_GENESYS_LAN"	     )
	ITEM(	DRV_PS_DEV_TYPE_LAMBDA_GENESYS_PLUS	 	 ,"LAMBDA_GENESYS_PLUS"  	 ) 
	ITEM(	DRV_PS_DEV_TYPE_POWERBOX	 	         ,"POWERBOX"  	     		 )
	ITEM(	DRV_PS_DEV_TYPE_VOXPOWER_NEVO600S        ,"VoxPower_Nevo600S"  	     )
	ITEM(	DRV_PS_DEV_TYPE_KEITHLEY_26XX            ,"KEITHLEY_26XX"  	     	 ) 
	ITEM(	DRV_PS_DEV_TYPE_AGILENT_67XX             ,"AGILENT_67XX"  	     	 )  
	ITEM(	DRV_PS_DEV_TYPE_MAX				,""								     )	// always MAX last
	// Device Types Definitions - finish
		
#if !defined(_DRV_PS_DEV_TYPE_STRINGS_ONLY_) && !defined(DRV_PS_H)
		} DRV_PS_DEV_TYPE_T ;
#else
 #ifdef _DRV_PS_DEV_TYPE_STRINGS_ONLY_
		} ;	
 #undef _DRV_PS_DEV_TYPE_STRINGS_ONLY_
 #endif
#endif
#undef ITEM

//=================================================================================================
//supported models for DRV_PS_DEV_TYPE_LAMBDA_GENESYS:
/*
			"GEN40-19"
			"GENH40-19"  
			"GEN40-38"
			"GEN40-85"
			"GEN30-110"
			"GEN30-50"
			"GEN40_85_X2"
			"GEN60-40"
			"GEN60-14"
			"GENH60-12"
			"GEN50-30"
			"Z36-12"
			"Z36-24" 
			"Z60-7"
			"Z60-14"
			"Z36-6" 
			"GEN80-187.5"
			"GEN100-150"
*/

//=================================================================================================	
	
//=================================================================================================
//							Start of "Regular" include file
//=================================================================================================
#ifndef DRV_PS_H
#define DRV_PS_H

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

#define MAX_SIZE_CURRENT_SAMPLES 				5000  
  																		
  																		
//=================================================================================================
//								External Globals Declerations
//=================================================================================================




//=================================================================================================
//									MACROs Definition
//=================================================================================================

// GUI States - used with DrvPS_SetGUIState()
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
int 	__stdcall 	DrvPS_InitDriver 			( char sInitFile[] ) ;
void 	__stdcall 	DrvPS_CloseDriver 			( void ) ;
void	__stdcall	DrvPS_WaitForMainQuit		( void ) ; // runs till the QUIT is pressed and finished (used only for the EXE panel)
int		__stdcall	DrvPS_GetNumberOfDevices	( void ) ;
void	__stdcall	DrvPS_SetMainPanelState		( int iGuiState ) ; // GUI_STATE_...NORMAL/MINIMIZED/HIDDEN
int 	__stdcall 	DrvPS_GetMainPanelState 	( void );  // NORMAL/MINIMIZED/HIDDEN  
void	__stdcall	DrvPS_SetPanelsBackColor	( unsigned int uColor ) ; 
int 	__stdcall	DrvPS_GetDriverVersion 		( char *psVersion , int* piMajor , int* piMinor , int* piBuild ) ; // XX.YY (Build ZZZZ)
void 	__stdcall 	DrvPS_SetToCloseDriverOnQuit( void ) ;
//void 	__stdcall 	DrvPS_GetLastErrorString 	(char* sDevName, char sError[] )    ;

int 	__stdcall 	DrvPS_GetDefaultDriversINIFile ( char *psDriversINI, int iBufferLength ) ; // used in DrvPS_Panel.exe // Added since V2.0.0
int		__stdcall	DrvPS_GetLogState 		( void ) ;			// Added since V2.0.0
void 	__stdcall	DrvPS_SetLogState 		( int iLogState ) ; // LOG_STATE_...NONE/DEBUG/MESSAGE/WARN/ERROR/COMMAND/START_STOP_FUNCTION/ALL (must include "LoggerClientCVI_Exports.h") // Added since V2.0.0
BOOL 	__stdcall 	DrvPS_GetFrequenciesVisible ( void ) ; // Added since V2.0.0
void 	__stdcall 	DrvPS_SetFrequenciesVisible ( BOOL bShowFreq )  ; // Added since V2.0.0



// Device
int		__stdcall	DrvPS_AddDevice				( char sDevName[], char sConnectionString[], DRV_PS_DEV_TYPE_T eDevType, BOOL bSimulation , BOOL bResetDevice, ...) ;
int		__stdcall	DrvPS_AddDeviceFromFile		( char sDevName[], char sInitFile[] ) ; 	
int		__stdcall	DrvPS_AddDevicesFromFile	( char sInitFile[] ) ; 	
int		__stdcall	DrvPS_CloseDevice			( char sDevName[] ) ;
void	__stdcall	DrvPS_CloseAllDevices		( void ) ;
int		__stdcall	DrvPS_ReInitDevice			( char sDevName[] , BOOL bResetDevice ) ;


int		__stdcall	DrvPS_GetDevType			( char sDevName[] ) ;
void	__stdcall	DrvPS_GetDevConnectionString( char sDevName[], char* psConnectionString ) ;
BOOL	__stdcall	DrvPS_GetSimulation			( char sDevName[] ) ;
int		__stdcall	DrvPS_SelfTest				( char sDevName[] ) ;
int		__stdcall	DrvPS_Reset					( char sDevName[] ) ;
int		__stdcall	DrvPS_GetDeviceError		( char sDevName[] , int* piErrorCode, char* psErrorString , char* psErrorLongDescription ) ; // Get Error status from the device   
long 	__stdcall 	DrvPS_GetDeviceHandle		( char sDevName[] ) ;

void	__stdcall	DrvPS_SetGuiReadOnly		( BOOL bReadOnly ) ;
BOOL	__stdcall	DrvPS_GetGuiReadonly		( void ) ;

void	__stdcall	DrvPS_SetDevicePanelState	( char sDevName[], int iGuiState ) ; // NORMAL/MINIMIZED/MINIMIZED_TO_ICON/MAXIMIZED/HIDDEN
int		__stdcall	DrvPS_GetDevicePanelState	( char sDevName[] ) ; // NORMAL/MINIMIZED/MINIMIZED_TO_ICON/MAXIMIZED/HIDDEN
void	__stdcall	DrvPS_HideAll				( void ) ;
void	__stdcall	DrvPS_MinimizeAll			( void ) ;
void	__stdcall	DrvPS_ShowAll				( void ) ;
void	__stdcall	DrvPS_DockAll				( void ) ;
void	__stdcall	DrvPS_UnDockAll				( void ) ;

void	__stdcall	DrvPS_SetPanelUpdateRate	( char sDevName[], int iIntervalmSec ) ; // -1=Manual 0..
int		__stdcall	DrvPS_GetPanelUpdateRate	( char sDevName[] ) ; // -1=Manual 0..
void  	__stdcall	DrvPS_UpdateDevicePanel		( char sDevName[] ) ;
void  	__stdcall	DrvPS_UpdateGuiAtEndFunction( char sDevName[] ,BOOL bIsUpdate) ;



// Specific Driver Functions

int		__stdcall	DrvPS_SetVoltage 	  	  		 	( char sDevName[], double dVolt ) ;
int		__stdcall	DrvPS_SetUnderVoltageProtection 	( char sDevName[], double dUnderVolt ) ;
int		__stdcall	DrvPS_SetOverVoltageProtection 	  	( char sDevName[], double dOverVolt ) ;
int		__stdcall	DrvPS_SetOutput		      			( char sDevName[], BOOL bOn ) ;
int		__stdcall	DrvPS_SetCurrentLimit	 			( char sDevName[], double dCurr ) ;
int		__stdcall	DrvPS_GetVoltage		  			( char sDevName[], double *pdProgrammedVolt, double *pdActualVolt ) ;
int  	__stdcall   DrvPS_GetCurrent          			( char sDevName[], double *pdProgrammedCurr, double *pdActualCurr );

int 	__stdcall   DrvPS_SetAdderss 					( char sDevName[]);
int 	__stdcall   DrvPS_GetActualCurrent 				( char sDevName[], double *pdActualCurr, BOOL bFastMode ); //if  bFastMode == false -> setAddres not occur and need to be set before calling this function 
int 	__stdcall 	DrvPS_GetCurrentSamples				( char sDevName[], double dSecondsTimeout, int iMaxArrSize, double* adActualCurr, double* adTime, int *iNumOfSamples ); 

int	    __stdcall   DrvPS_GetUnderOverVoltageProtection ( char sDevName[], double *pdUnderVolt, double *pdOverVolt ); 
int  	__stdcall   DrvPS_SetFoldBack         			( char sDevName[], int iFoldStatus ) ;
int  	__stdcall   DrvPS_GetFoldBack         			( char sDevName[], int *piFold  ) ; 
int     __stdcall 	DrvPS_GetOverCurrentStatus 			( char sDevName[], int *piOverCurr )  ;
int 	__stdcall	DrvPS_GetFoldStatus 				( char sDevName[], int *piFold ) ;
int 	__stdcall 	DrvPS_GetOutput 					( char sDevName[], BOOL* pbOn ) ;


int		__stdcall	DrvPS_Group_SetOutput		      	( char sDevName[],  BOOL* pabSetThisDevice,int iArraySize, BOOL bOn ) ;
int		__stdcall	DrvPS_Group_GetVoltage		  		( char sDevName[], double *padProgrammedVolt, int iSizeArrayProgrammedVolt, double *padActualVolt, int iSizeArrayActualVolt ) ;
int  	__stdcall   DrvPS_Group_GetCurrent          	( char sDevName[], double *padProgrammedCurr, int iSizeArrayProgrammedCurr, double *padActualCurr, int iSizeArrayActualCurr );
//This function is implemented for Power Box only. It returns status of the whole box, does no matter which device is called at 'sDevName'
//int 	__stdcall	DrvPS_GetCalAndTemperatureStatus	( char sDevName[], char * psStatusString ); 
//int	__stdcall   DrvPS_CheckRemote					( char sDevName[] );



//=================================================================================================
//		  						 End of Function Declerations
//=================================================================================================

#ifdef __cplusplus
}
#endif


#endif // DRV_PS_H
