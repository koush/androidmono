namespace android.database
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.database.Cursor_))]
	public interface Cursor  : global::MonoJavaBridge.IJavaObject 
	{
		short getShort(int arg0);
		int getInt(int arg0);
		long getLong(int arg0);
		float getFloat(int arg0);
		double getDouble(int arg0);
		void close();
		global::java.lang.String getString(int arg0);
		bool isFirst();
		bool isClosed();
		int getPosition();
		global::android.os.Bundle getExtras();
		void registerContentObserver(android.database.ContentObserver arg0);
		void unregisterContentObserver(android.database.ContentObserver arg0);
		int getCount();
		bool move(int arg0);
		bool moveToPosition(int arg0);
		bool moveToFirst();
		bool moveToLast();
		bool moveToNext();
		bool moveToPrevious();
		bool isLast();
		bool isBeforeFirst();
		bool isAfterLast();
		int getColumnIndex(java.lang.String arg0);
		int getColumnIndexOrThrow(java.lang.String arg0);
		global::java.lang.String getColumnName(int arg0);
		global::java.lang.String[] getColumnNames();
		int getColumnCount();
		byte[] getBlob(int arg0);
		void copyStringToBuffer(int arg0, android.database.CharArrayBuffer arg1);
		bool isNull(int arg0);
		void deactivate();
		bool requery();
		void registerDataSetObserver(android.database.DataSetObserver arg0);
		void unregisterDataSetObserver(android.database.DataSetObserver arg0);
		void setNotificationUri(android.content.ContentResolver arg0, android.net.Uri arg1);
		bool getWantsAllOnMoveCalls();
		global::android.os.Bundle respond(android.os.Bundle arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.database.Cursor))]
	public sealed partial class Cursor_ : java.lang.Object, Cursor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Cursor_()
		{
			InitJNI();
		}
		internal Cursor_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getShort2561;
		 short android.database.Cursor.getShort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::android.database.Cursor_._getShort2561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._getShort2561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt2562;
		 int android.database.Cursor.getInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.Cursor_._getInt2562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._getInt2562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong2563;
		 long android.database.Cursor.getLong(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.database.Cursor_._getLong2563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._getLong2563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat2564;
		 float android.database.Cursor.getFloat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.database.Cursor_._getFloat2564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._getFloat2564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble2565;
		 double android.database.Cursor.getDouble(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.database.Cursor_._getDouble2565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._getDouble2565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close2566;
		 void android.database.Cursor.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.Cursor_._close2566);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._close2566);
		}
		internal static global::MonoJavaBridge.MethodId _getString2567;
		 global::java.lang.String android.database.Cursor.getString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.Cursor_._getString2567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._getString2567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isFirst2568;
		 bool android.database.Cursor.isFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._isFirst2568);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._isFirst2568);
		}
		internal static global::MonoJavaBridge.MethodId _isClosed2569;
		 bool android.database.Cursor.isClosed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._isClosed2569);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._isClosed2569);
		}
		internal static global::MonoJavaBridge.MethodId _getPosition2570;
		 int android.database.Cursor.getPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.Cursor_._getPosition2570);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._getPosition2570);
		}
		internal static global::MonoJavaBridge.MethodId _getExtras2571;
		 global::android.os.Bundle android.database.Cursor.getExtras() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.Cursor_._getExtras2571)) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._getExtras2571)) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _registerContentObserver2572;
		 void android.database.Cursor.registerContentObserver(android.database.ContentObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.Cursor_._registerContentObserver2572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._registerContentObserver2572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterContentObserver2573;
		 void android.database.Cursor.unregisterContentObserver(android.database.ContentObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.Cursor_._unregisterContentObserver2573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._unregisterContentObserver2573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCount2574;
		 int android.database.Cursor.getCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.Cursor_._getCount2574);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._getCount2574);
		}
		internal static global::MonoJavaBridge.MethodId _move2575;
		 bool android.database.Cursor.move(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._move2575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._move2575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveToPosition2576;
		 bool android.database.Cursor.moveToPosition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._moveToPosition2576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._moveToPosition2576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveToFirst2577;
		 bool android.database.Cursor.moveToFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._moveToFirst2577);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._moveToFirst2577);
		}
		internal static global::MonoJavaBridge.MethodId _moveToLast2578;
		 bool android.database.Cursor.moveToLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._moveToLast2578);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._moveToLast2578);
		}
		internal static global::MonoJavaBridge.MethodId _moveToNext2579;
		 bool android.database.Cursor.moveToNext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._moveToNext2579);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._moveToNext2579);
		}
		internal static global::MonoJavaBridge.MethodId _moveToPrevious2580;
		 bool android.database.Cursor.moveToPrevious() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._moveToPrevious2580);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._moveToPrevious2580);
		}
		internal static global::MonoJavaBridge.MethodId _isLast2581;
		 bool android.database.Cursor.isLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._isLast2581);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._isLast2581);
		}
		internal static global::MonoJavaBridge.MethodId _isBeforeFirst2582;
		 bool android.database.Cursor.isBeforeFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._isBeforeFirst2582);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._isBeforeFirst2582);
		}
		internal static global::MonoJavaBridge.MethodId _isAfterLast2583;
		 bool android.database.Cursor.isAfterLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._isAfterLast2583);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._isAfterLast2583);
		}
		internal static global::MonoJavaBridge.MethodId _getColumnIndex2584;
		 int android.database.Cursor.getColumnIndex(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.Cursor_._getColumnIndex2584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._getColumnIndex2584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnIndexOrThrow2585;
		 int android.database.Cursor.getColumnIndexOrThrow(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.Cursor_._getColumnIndexOrThrow2585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._getColumnIndexOrThrow2585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnName2586;
		 global::java.lang.String android.database.Cursor.getColumnName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.Cursor_._getColumnName2586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._getColumnName2586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNames2587;
		 global::java.lang.String[] android.database.Cursor.getColumnNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.Cursor_._getColumnNames2587)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._getColumnNames2587)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getColumnCount2588;
		 int android.database.Cursor.getColumnCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.Cursor_._getColumnCount2588);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._getColumnCount2588);
		}
		internal static global::MonoJavaBridge.MethodId _getBlob2589;
		 byte[] android.database.Cursor.getBlob(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.Cursor_._getBlob2589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._getBlob2589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _copyStringToBuffer2590;
		 void android.database.Cursor.copyStringToBuffer(int arg0, android.database.CharArrayBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.Cursor_._copyStringToBuffer2590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._copyStringToBuffer2590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isNull2591;
		 bool android.database.Cursor.isNull(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._isNull2591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._isNull2591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deactivate2592;
		 void android.database.Cursor.deactivate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.Cursor_._deactivate2592);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._deactivate2592);
		}
		internal static global::MonoJavaBridge.MethodId _requery2593;
		 bool android.database.Cursor.requery() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._requery2593);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._requery2593);
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver2594;
		 void android.database.Cursor.registerDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.Cursor_._registerDataSetObserver2594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._registerDataSetObserver2594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterDataSetObserver2595;
		 void android.database.Cursor.unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.Cursor_._unregisterDataSetObserver2595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._unregisterDataSetObserver2595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNotificationUri2596;
		 void android.database.Cursor.setNotificationUri(android.content.ContentResolver arg0, android.net.Uri arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.Cursor_._setNotificationUri2596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._setNotificationUri2596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getWantsAllOnMoveCalls2597;
		 bool android.database.Cursor.getWantsAllOnMoveCalls() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.Cursor_._getWantsAllOnMoveCalls2597);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._getWantsAllOnMoveCalls2597);
		}
		internal static global::MonoJavaBridge.MethodId _respond2598;
		 global::android.os.Bundle android.database.Cursor.respond(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.Cursor_._respond2598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.Cursor_.staticClass, global::android.database.Cursor_._respond2598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.Cursor_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/Cursor"));
			global::android.database.Cursor_._getShort2561 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getShort", "(I)S");
			global::android.database.Cursor_._getInt2562 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getInt", "(I)I");
			global::android.database.Cursor_._getLong2563 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getLong", "(I)J");
			global::android.database.Cursor_._getFloat2564 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getFloat", "(I)F");
			global::android.database.Cursor_._getDouble2565 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getDouble", "(I)D");
			global::android.database.Cursor_._close2566 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "close", "()V");
			global::android.database.Cursor_._getString2567 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getString", "(I)Ljava/lang/String;");
			global::android.database.Cursor_._isFirst2568 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "isFirst", "()Z");
			global::android.database.Cursor_._isClosed2569 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "isClosed", "()Z");
			global::android.database.Cursor_._getPosition2570 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getPosition", "()I");
			global::android.database.Cursor_._getExtras2571 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getExtras", "()Landroid/os/Bundle;");
			global::android.database.Cursor_._registerContentObserver2572 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "registerContentObserver", "(Landroid/database/ContentObserver;)V");
			global::android.database.Cursor_._unregisterContentObserver2573 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "unregisterContentObserver", "(Landroid/database/ContentObserver;)V");
			global::android.database.Cursor_._getCount2574 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getCount", "()I");
			global::android.database.Cursor_._move2575 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "move", "(I)Z");
			global::android.database.Cursor_._moveToPosition2576 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "moveToPosition", "(I)Z");
			global::android.database.Cursor_._moveToFirst2577 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "moveToFirst", "()Z");
			global::android.database.Cursor_._moveToLast2578 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "moveToLast", "()Z");
			global::android.database.Cursor_._moveToNext2579 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "moveToNext", "()Z");
			global::android.database.Cursor_._moveToPrevious2580 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "moveToPrevious", "()Z");
			global::android.database.Cursor_._isLast2581 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "isLast", "()Z");
			global::android.database.Cursor_._isBeforeFirst2582 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "isBeforeFirst", "()Z");
			global::android.database.Cursor_._isAfterLast2583 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "isAfterLast", "()Z");
			global::android.database.Cursor_._getColumnIndex2584 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getColumnIndex", "(Ljava/lang/String;)I");
			global::android.database.Cursor_._getColumnIndexOrThrow2585 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getColumnIndexOrThrow", "(Ljava/lang/String;)I");
			global::android.database.Cursor_._getColumnName2586 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getColumnName", "(I)Ljava/lang/String;");
			global::android.database.Cursor_._getColumnNames2587 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getColumnNames", "()[Ljava/lang/String;");
			global::android.database.Cursor_._getColumnCount2588 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getColumnCount", "()I");
			global::android.database.Cursor_._getBlob2589 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getBlob", "(I)[B");
			global::android.database.Cursor_._copyStringToBuffer2590 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V");
			global::android.database.Cursor_._isNull2591 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "isNull", "(I)Z");
			global::android.database.Cursor_._deactivate2592 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "deactivate", "()V");
			global::android.database.Cursor_._requery2593 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "requery", "()Z");
			global::android.database.Cursor_._registerDataSetObserver2594 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.database.Cursor_._unregisterDataSetObserver2595 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.database.Cursor_._setNotificationUri2596 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V");
			global::android.database.Cursor_._getWantsAllOnMoveCalls2597 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "getWantsAllOnMoveCalls", "()Z");
			global::android.database.Cursor_._respond2598 = @__env.GetMethodIDNoThrow(global::android.database.Cursor_.staticClass, "respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;");
		}
	}
}
