namespace android.database
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CursorWrapper : java.lang.Object, Cursor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CursorWrapper()
		{
			InitJNI();
		}
		protected CursorWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getShort2644;
		public virtual short getShort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::android.database.CursorWrapper._getShort2644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getShort2644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt2645;
		public virtual int getInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.CursorWrapper._getInt2645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getInt2645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong2646;
		public virtual long getLong(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.database.CursorWrapper._getLong2646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getLong2646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat2647;
		public virtual float getFloat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.database.CursorWrapper._getFloat2647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getFloat2647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble2648;
		public virtual double getDouble(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.database.CursorWrapper._getDouble2648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getDouble2648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close2649;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CursorWrapper._close2649);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._close2649);
		}
		internal static global::MonoJavaBridge.MethodId _getString2650;
		public virtual global::java.lang.String getString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.CursorWrapper._getString2650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getString2650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isFirst2651;
		public virtual bool isFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper._isFirst2651);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._isFirst2651);
		}
		internal static global::MonoJavaBridge.MethodId _isClosed2652;
		public virtual bool isClosed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper._isClosed2652);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._isClosed2652);
		}
		internal static global::MonoJavaBridge.MethodId _getPosition2653;
		public virtual int getPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.CursorWrapper._getPosition2653);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getPosition2653);
		}
		internal static global::MonoJavaBridge.MethodId _getExtras2654;
		public virtual global::android.os.Bundle getExtras() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.CursorWrapper._getExtras2654)) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getExtras2654)) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _registerContentObserver2655;
		public virtual void registerContentObserver(android.database.ContentObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CursorWrapper._registerContentObserver2655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._registerContentObserver2655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterContentObserver2656;
		public virtual void unregisterContentObserver(android.database.ContentObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CursorWrapper._unregisterContentObserver2656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._unregisterContentObserver2656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCount2657;
		public virtual int getCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.CursorWrapper._getCount2657);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getCount2657);
		}
		internal static global::MonoJavaBridge.MethodId _move2658;
		public virtual bool move(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper._move2658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._move2658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveToPosition2659;
		public virtual bool moveToPosition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper._moveToPosition2659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._moveToPosition2659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveToFirst2660;
		public virtual bool moveToFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper._moveToFirst2660);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._moveToFirst2660);
		}
		internal static global::MonoJavaBridge.MethodId _moveToLast2661;
		public virtual bool moveToLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper._moveToLast2661);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._moveToLast2661);
		}
		internal static global::MonoJavaBridge.MethodId _moveToNext2662;
		public virtual bool moveToNext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper._moveToNext2662);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._moveToNext2662);
		}
		internal static global::MonoJavaBridge.MethodId _moveToPrevious2663;
		public virtual bool moveToPrevious() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper._moveToPrevious2663);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._moveToPrevious2663);
		}
		internal static global::MonoJavaBridge.MethodId _isLast2664;
		public virtual bool isLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper._isLast2664);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._isLast2664);
		}
		internal static global::MonoJavaBridge.MethodId _isBeforeFirst2665;
		public virtual bool isBeforeFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper._isBeforeFirst2665);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._isBeforeFirst2665);
		}
		internal static global::MonoJavaBridge.MethodId _isAfterLast2666;
		public virtual bool isAfterLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper._isAfterLast2666);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._isAfterLast2666);
		}
		internal static global::MonoJavaBridge.MethodId _getColumnIndex2667;
		public virtual int getColumnIndex(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.CursorWrapper._getColumnIndex2667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getColumnIndex2667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnIndexOrThrow2668;
		public virtual int getColumnIndexOrThrow(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.CursorWrapper._getColumnIndexOrThrow2668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getColumnIndexOrThrow2668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnName2669;
		public virtual global::java.lang.String getColumnName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.CursorWrapper._getColumnName2669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getColumnName2669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNames2670;
		public virtual global::java.lang.String[] getColumnNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.CursorWrapper._getColumnNames2670)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getColumnNames2670)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getColumnCount2671;
		public virtual int getColumnCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.CursorWrapper._getColumnCount2671);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getColumnCount2671);
		}
		internal static global::MonoJavaBridge.MethodId _getBlob2672;
		public virtual byte[] getBlob(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.CursorWrapper._getBlob2672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getBlob2672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _copyStringToBuffer2673;
		public virtual void copyStringToBuffer(int arg0, android.database.CharArrayBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CursorWrapper._copyStringToBuffer2673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._copyStringToBuffer2673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isNull2674;
		public virtual bool isNull(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper._isNull2674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._isNull2674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deactivate2675;
		public virtual void deactivate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CursorWrapper._deactivate2675);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._deactivate2675);
		}
		internal static global::MonoJavaBridge.MethodId _requery2676;
		public virtual bool requery() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper._requery2676);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._requery2676);
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver2677;
		public virtual void registerDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CursorWrapper._registerDataSetObserver2677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._registerDataSetObserver2677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterDataSetObserver2678;
		public virtual void unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CursorWrapper._unregisterDataSetObserver2678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._unregisterDataSetObserver2678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNotificationUri2679;
		public virtual void setNotificationUri(android.content.ContentResolver arg0, android.net.Uri arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CursorWrapper._setNotificationUri2679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._setNotificationUri2679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getWantsAllOnMoveCalls2680;
		public virtual bool getWantsAllOnMoveCalls() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper._getWantsAllOnMoveCalls2680);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getWantsAllOnMoveCalls2680);
		}
		internal static global::MonoJavaBridge.MethodId _respond2681;
		public virtual global::android.os.Bundle respond(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.CursorWrapper._respond2681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._respond2681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _CursorWrapper2682;
		public CursorWrapper(android.database.Cursor arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._CursorWrapper2682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.CursorWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/CursorWrapper"));
			global::android.database.CursorWrapper._getShort2644 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getShort", "(I)S");
			global::android.database.CursorWrapper._getInt2645 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getInt", "(I)I");
			global::android.database.CursorWrapper._getLong2646 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getLong", "(I)J");
			global::android.database.CursorWrapper._getFloat2647 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getFloat", "(I)F");
			global::android.database.CursorWrapper._getDouble2648 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getDouble", "(I)D");
			global::android.database.CursorWrapper._close2649 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "close", "()V");
			global::android.database.CursorWrapper._getString2650 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getString", "(I)Ljava/lang/String;");
			global::android.database.CursorWrapper._isFirst2651 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "isFirst", "()Z");
			global::android.database.CursorWrapper._isClosed2652 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "isClosed", "()Z");
			global::android.database.CursorWrapper._getPosition2653 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getPosition", "()I");
			global::android.database.CursorWrapper._getExtras2654 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getExtras", "()Landroid/os/Bundle;");
			global::android.database.CursorWrapper._registerContentObserver2655 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "registerContentObserver", "(Landroid/database/ContentObserver;)V");
			global::android.database.CursorWrapper._unregisterContentObserver2656 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "unregisterContentObserver", "(Landroid/database/ContentObserver;)V");
			global::android.database.CursorWrapper._getCount2657 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getCount", "()I");
			global::android.database.CursorWrapper._move2658 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "move", "(I)Z");
			global::android.database.CursorWrapper._moveToPosition2659 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "moveToPosition", "(I)Z");
			global::android.database.CursorWrapper._moveToFirst2660 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "moveToFirst", "()Z");
			global::android.database.CursorWrapper._moveToLast2661 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "moveToLast", "()Z");
			global::android.database.CursorWrapper._moveToNext2662 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "moveToNext", "()Z");
			global::android.database.CursorWrapper._moveToPrevious2663 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "moveToPrevious", "()Z");
			global::android.database.CursorWrapper._isLast2664 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "isLast", "()Z");
			global::android.database.CursorWrapper._isBeforeFirst2665 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "isBeforeFirst", "()Z");
			global::android.database.CursorWrapper._isAfterLast2666 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "isAfterLast", "()Z");
			global::android.database.CursorWrapper._getColumnIndex2667 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getColumnIndex", "(Ljava/lang/String;)I");
			global::android.database.CursorWrapper._getColumnIndexOrThrow2668 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getColumnIndexOrThrow", "(Ljava/lang/String;)I");
			global::android.database.CursorWrapper._getColumnName2669 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getColumnName", "(I)Ljava/lang/String;");
			global::android.database.CursorWrapper._getColumnNames2670 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getColumnNames", "()[Ljava/lang/String;");
			global::android.database.CursorWrapper._getColumnCount2671 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getColumnCount", "()I");
			global::android.database.CursorWrapper._getBlob2672 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getBlob", "(I)[B");
			global::android.database.CursorWrapper._copyStringToBuffer2673 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V");
			global::android.database.CursorWrapper._isNull2674 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "isNull", "(I)Z");
			global::android.database.CursorWrapper._deactivate2675 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "deactivate", "()V");
			global::android.database.CursorWrapper._requery2676 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "requery", "()Z");
			global::android.database.CursorWrapper._registerDataSetObserver2677 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.database.CursorWrapper._unregisterDataSetObserver2678 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.database.CursorWrapper._setNotificationUri2679 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V");
			global::android.database.CursorWrapper._getWantsAllOnMoveCalls2680 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getWantsAllOnMoveCalls", "()Z");
			global::android.database.CursorWrapper._respond2681 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;");
			global::android.database.CursorWrapper._CursorWrapper2682 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "<init>", "(Landroid/database/Cursor;)V");
		}
	}
}
