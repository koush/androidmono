namespace android.database
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.database.CrossProcessCursor_))]
	public interface CrossProcessCursor : Cursor
	{
		global::android.database.CursorWindow getWindow();
		bool onMove(int arg0, int arg1);
		void fillWindow(int arg0, android.database.CursorWindow arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.database.CrossProcessCursor))]
	public sealed partial class CrossProcessCursor_ : java.lang.Object, CrossProcessCursor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CrossProcessCursor_()
		{
			InitJNI();
		}
		internal CrossProcessCursor_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getWindow2520;
		 global::android.database.CursorWindow android.database.CrossProcessCursor.getWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._getWindow2520)) as android.database.CursorWindow;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._getWindow2520)) as android.database.CursorWindow;
		}
		internal static global::MonoJavaBridge.MethodId _onMove2521;
		 bool android.database.CrossProcessCursor.onMove(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._onMove2521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._onMove2521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _fillWindow2522;
		 void android.database.CrossProcessCursor.fillWindow(int arg0, android.database.CursorWindow arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._fillWindow2522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._fillWindow2522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getShort2523;
		 short android.database.Cursor.getShort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._getShort2523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._getShort2523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt2524;
		 int android.database.Cursor.getInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._getInt2524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._getInt2524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong2525;
		 long android.database.Cursor.getLong(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._getLong2525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._getLong2525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat2526;
		 float android.database.Cursor.getFloat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._getFloat2526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._getFloat2526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble2527;
		 double android.database.Cursor.getDouble(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._getDouble2527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._getDouble2527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close2528;
		 void android.database.Cursor.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._close2528);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._close2528);
		}
		internal static global::MonoJavaBridge.MethodId _getString2529;
		 global::java.lang.String android.database.Cursor.getString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._getString2529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._getString2529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isFirst2530;
		 bool android.database.Cursor.isFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._isFirst2530);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._isFirst2530);
		}
		internal static global::MonoJavaBridge.MethodId _isClosed2531;
		 bool android.database.Cursor.isClosed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._isClosed2531);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._isClosed2531);
		}
		internal static global::MonoJavaBridge.MethodId _getPosition2532;
		 int android.database.Cursor.getPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._getPosition2532);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._getPosition2532);
		}
		internal static global::MonoJavaBridge.MethodId _getExtras2533;
		 global::android.os.Bundle android.database.Cursor.getExtras() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._getExtras2533)) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._getExtras2533)) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _registerContentObserver2534;
		 void android.database.Cursor.registerContentObserver(android.database.ContentObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._registerContentObserver2534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._registerContentObserver2534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterContentObserver2535;
		 void android.database.Cursor.unregisterContentObserver(android.database.ContentObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._unregisterContentObserver2535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._unregisterContentObserver2535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCount2536;
		 int android.database.Cursor.getCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._getCount2536);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._getCount2536);
		}
		internal static global::MonoJavaBridge.MethodId _move2537;
		 bool android.database.Cursor.move(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._move2537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._move2537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveToPosition2538;
		 bool android.database.Cursor.moveToPosition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._moveToPosition2538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._moveToPosition2538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveToFirst2539;
		 bool android.database.Cursor.moveToFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._moveToFirst2539);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._moveToFirst2539);
		}
		internal static global::MonoJavaBridge.MethodId _moveToLast2540;
		 bool android.database.Cursor.moveToLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._moveToLast2540);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._moveToLast2540);
		}
		internal static global::MonoJavaBridge.MethodId _moveToNext2541;
		 bool android.database.Cursor.moveToNext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._moveToNext2541);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._moveToNext2541);
		}
		internal static global::MonoJavaBridge.MethodId _moveToPrevious2542;
		 bool android.database.Cursor.moveToPrevious() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._moveToPrevious2542);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._moveToPrevious2542);
		}
		internal static global::MonoJavaBridge.MethodId _isLast2543;
		 bool android.database.Cursor.isLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._isLast2543);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._isLast2543);
		}
		internal static global::MonoJavaBridge.MethodId _isBeforeFirst2544;
		 bool android.database.Cursor.isBeforeFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._isBeforeFirst2544);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._isBeforeFirst2544);
		}
		internal static global::MonoJavaBridge.MethodId _isAfterLast2545;
		 bool android.database.Cursor.isAfterLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._isAfterLast2545);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._isAfterLast2545);
		}
		internal static global::MonoJavaBridge.MethodId _getColumnIndex2546;
		 int android.database.Cursor.getColumnIndex(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._getColumnIndex2546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._getColumnIndex2546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnIndexOrThrow2547;
		 int android.database.Cursor.getColumnIndexOrThrow(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._getColumnIndexOrThrow2547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._getColumnIndexOrThrow2547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnName2548;
		 global::java.lang.String android.database.Cursor.getColumnName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._getColumnName2548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._getColumnName2548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNames2549;
		 global::java.lang.String[] android.database.Cursor.getColumnNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._getColumnNames2549)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._getColumnNames2549)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getColumnCount2550;
		 int android.database.Cursor.getColumnCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._getColumnCount2550);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._getColumnCount2550);
		}
		internal static global::MonoJavaBridge.MethodId _getBlob2551;
		 byte[] android.database.Cursor.getBlob(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._getBlob2551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._getBlob2551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _copyStringToBuffer2552;
		 void android.database.Cursor.copyStringToBuffer(int arg0, android.database.CharArrayBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._copyStringToBuffer2552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._copyStringToBuffer2552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isNull2553;
		 bool android.database.Cursor.isNull(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._isNull2553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._isNull2553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deactivate2554;
		 void android.database.Cursor.deactivate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._deactivate2554);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._deactivate2554);
		}
		internal static global::MonoJavaBridge.MethodId _requery2555;
		 bool android.database.Cursor.requery() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._requery2555);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._requery2555);
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver2556;
		 void android.database.Cursor.registerDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._registerDataSetObserver2556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._registerDataSetObserver2556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterDataSetObserver2557;
		 void android.database.Cursor.unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._unregisterDataSetObserver2557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._unregisterDataSetObserver2557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNotificationUri2558;
		 void android.database.Cursor.setNotificationUri(android.content.ContentResolver arg0, android.net.Uri arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._setNotificationUri2558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._setNotificationUri2558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getWantsAllOnMoveCalls2559;
		 bool android.database.Cursor.getWantsAllOnMoveCalls() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._getWantsAllOnMoveCalls2559);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._getWantsAllOnMoveCalls2559);
		}
		internal static global::MonoJavaBridge.MethodId _respond2560;
		 global::android.os.Bundle android.database.Cursor.respond(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.CrossProcessCursor_._respond2560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.CrossProcessCursor_.staticClass, global::android.database.CrossProcessCursor_._respond2560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.CrossProcessCursor_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/CrossProcessCursor"));
			global::android.database.CrossProcessCursor_._getWindow2520 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "getWindow", "()Landroid/database/CursorWindow;");
			global::android.database.CrossProcessCursor_._onMove2521 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "onMove", "(II)Z");
			global::android.database.CrossProcessCursor_._fillWindow2522 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "fillWindow", "(ILandroid/database/CursorWindow;)V");
			global::android.database.CrossProcessCursor_._getShort2523 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "getShort", "(I)S");
			global::android.database.CrossProcessCursor_._getInt2524 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "getInt", "(I)I");
			global::android.database.CrossProcessCursor_._getLong2525 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "getLong", "(I)J");
			global::android.database.CrossProcessCursor_._getFloat2526 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "getFloat", "(I)F");
			global::android.database.CrossProcessCursor_._getDouble2527 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "getDouble", "(I)D");
			global::android.database.CrossProcessCursor_._close2528 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "close", "()V");
			global::android.database.CrossProcessCursor_._getString2529 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "getString", "(I)Ljava/lang/String;");
			global::android.database.CrossProcessCursor_._isFirst2530 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "isFirst", "()Z");
			global::android.database.CrossProcessCursor_._isClosed2531 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "isClosed", "()Z");
			global::android.database.CrossProcessCursor_._getPosition2532 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "getPosition", "()I");
			global::android.database.CrossProcessCursor_._getExtras2533 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "getExtras", "()Landroid/os/Bundle;");
			global::android.database.CrossProcessCursor_._registerContentObserver2534 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "registerContentObserver", "(Landroid/database/ContentObserver;)V");
			global::android.database.CrossProcessCursor_._unregisterContentObserver2535 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "unregisterContentObserver", "(Landroid/database/ContentObserver;)V");
			global::android.database.CrossProcessCursor_._getCount2536 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "getCount", "()I");
			global::android.database.CrossProcessCursor_._move2537 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "move", "(I)Z");
			global::android.database.CrossProcessCursor_._moveToPosition2538 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "moveToPosition", "(I)Z");
			global::android.database.CrossProcessCursor_._moveToFirst2539 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "moveToFirst", "()Z");
			global::android.database.CrossProcessCursor_._moveToLast2540 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "moveToLast", "()Z");
			global::android.database.CrossProcessCursor_._moveToNext2541 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "moveToNext", "()Z");
			global::android.database.CrossProcessCursor_._moveToPrevious2542 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "moveToPrevious", "()Z");
			global::android.database.CrossProcessCursor_._isLast2543 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "isLast", "()Z");
			global::android.database.CrossProcessCursor_._isBeforeFirst2544 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "isBeforeFirst", "()Z");
			global::android.database.CrossProcessCursor_._isAfterLast2545 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "isAfterLast", "()Z");
			global::android.database.CrossProcessCursor_._getColumnIndex2546 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "getColumnIndex", "(Ljava/lang/String;)I");
			global::android.database.CrossProcessCursor_._getColumnIndexOrThrow2547 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "getColumnIndexOrThrow", "(Ljava/lang/String;)I");
			global::android.database.CrossProcessCursor_._getColumnName2548 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "getColumnName", "(I)Ljava/lang/String;");
			global::android.database.CrossProcessCursor_._getColumnNames2549 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "getColumnNames", "()[Ljava/lang/String;");
			global::android.database.CrossProcessCursor_._getColumnCount2550 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "getColumnCount", "()I");
			global::android.database.CrossProcessCursor_._getBlob2551 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "getBlob", "(I)[B");
			global::android.database.CrossProcessCursor_._copyStringToBuffer2552 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V");
			global::android.database.CrossProcessCursor_._isNull2553 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "isNull", "(I)Z");
			global::android.database.CrossProcessCursor_._deactivate2554 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "deactivate", "()V");
			global::android.database.CrossProcessCursor_._requery2555 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "requery", "()Z");
			global::android.database.CrossProcessCursor_._registerDataSetObserver2556 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.database.CrossProcessCursor_._unregisterDataSetObserver2557 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.database.CrossProcessCursor_._setNotificationUri2558 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V");
			global::android.database.CrossProcessCursor_._getWantsAllOnMoveCalls2559 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "getWantsAllOnMoveCalls", "()Z");
			global::android.database.CrossProcessCursor_._respond2560 = @__env.GetMethodIDNoThrow(global::android.database.CrossProcessCursor_.staticClass, "respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;");
		}
	}
}
