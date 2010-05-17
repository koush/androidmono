namespace android.view.inputmethod 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface InputConnection 
	{ 
		bool setSelection(int arg0, int arg1); 
		bool beginBatchEdit(); 
		bool endBatchEdit(); 
		java.lang.CharSequence getTextBeforeCursor(int arg0, int arg1); 
		java.lang.CharSequence getTextAfterCursor(int arg0, int arg1); 
		int getCursorCapsMode(int arg0); 
		android.view.inputmethod.ExtractedText getExtractedText(android.view.inputmethod.ExtractedTextRequest arg0, int arg1); 
		bool deleteSurroundingText(int arg0, int arg1); 
		bool setComposingText(java.lang.CharSequence arg0, int arg1); 
		bool finishComposingText(); 
		bool commitText(java.lang.CharSequence arg0, int arg1); 
		bool commitCompletion(android.view.inputmethod.CompletionInfo arg0); 
		bool performEditorAction(int arg0); 
		bool performContextMenuAction(int arg0); 
		bool sendKeyEvent(android.view.KeyEvent arg0); 
		bool clearMetaKeyStates(int arg0); 
		bool reportFullscreenMode(bool arg0); 
		bool performPrivateCommand(java.lang.String arg0, android.os.Bundle arg1); 
	} 
} 
