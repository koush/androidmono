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
		internal static global::MonoJavaBridge.MethodId _getShort4542;
		public virtual short getShort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::android.database.CursorWrapper._getShort4542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getShort4542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt4543;
		public virtual int getInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.CursorWrapper._getInt4543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getInt4543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong4544;
		public virtual long getLong(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.database.CursorWrapper._getLong4544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getLong4544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat4545;
		public virtual float getFloat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.database.CursorWrapper._getFloat4545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getFloat4545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble4546;
		public virtual double getDouble(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.database.CursorWrapper._getDouble4546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getDouble4546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close4547;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CursorWrapper._close4547);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._close4547);
		}
		internal static global::MonoJavaBridge.MethodId _getString4548;
		public virtual global::java.lang.String getString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.CursorWrapper._getString4548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getString4548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isFirst4549;
		public virtual bool isFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper._isFirst4549);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._isFirst4549);
		}
		internal static global::MonoJavaBridge.MethodId _isClosed4550;
		public virtual bool isClosed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper._isClosed4550);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._isClosed4550);
		}
		public new int Position
		{
			get
			{
				return getPosition();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPosition4551;
		public virtual int getPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.CursorWrapper._getPosition4551);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getPosition4551);
		}
		public new global::android.os.Bundle Extras
		{
			get
			{
				return getExtras();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExtras4552;
		public virtual global::android.os.Bundle getExtras() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.CursorWrapper._getExtras4552)) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getExtras4552)) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _registerContentObserver4553;
		public virtual void registerContentObserver(android.database.ContentObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CursorWrapper._registerContentObserver4553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._registerContentObserver4553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterContentObserver4554;
		public virtual void unregisterContentObserver(android.database.ContentObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CursorWrapper._unregisterContentObserver4554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._unregisterContentObserver4554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Count
		{
			get
			{
				return getCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCount4555;
		public virtual int getCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.CursorWrapper._getCount4555);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getCount4555);
		}
		internal static global::MonoJavaBridge.MethodId _move4556;
		public virtual bool move(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper._move4556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._move4556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveToPosition4557;
		public virtual bool moveToPosition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper._moveToPosition4557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._moveToPosition4557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveToFirst4558;
		public virtual bool moveToFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper._moveToFirst4558);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._moveToFirst4558);
		}
		internal static global::MonoJavaBridge.MethodId _moveToLast4559;
		public virtual bool moveToLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper._moveToLast4559);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._moveToLast4559);
		}
		internal static global::MonoJavaBridge.MethodId _moveToNext4560;
		public virtual bool moveToNext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper._moveToNext4560);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._moveToNext4560);
		}
		internal static global::MonoJavaBridge.MethodId _moveToPrevious4561;
		public virtual bool moveToPrevious() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper._moveToPrevious4561);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._moveToPrevious4561);
		}
		internal static global::MonoJavaBridge.MethodId _isLast4562;
		public virtual bool isLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper._isLast4562);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._isLast4562);
		}
		internal static global::MonoJavaBridge.MethodId _isBeforeFirst4563;
		public virtual bool isBeforeFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper._isBeforeFirst4563);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._isBeforeFirst4563);
		}
		internal static global::MonoJavaBridge.MethodId _isAfterLast4564;
		public virtual bool isAfterLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper._isAfterLast4564);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._isAfterLast4564);
		}
		internal static global::MonoJavaBridge.MethodId _getColumnIndex4565;
		public virtual int getColumnIndex(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.CursorWrapper._getColumnIndex4565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getColumnIndex4565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnIndexOrThrow4566;
		public virtual int getColumnIndexOrThrow(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.CursorWrapper._getColumnIndexOrThrow4566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getColumnIndexOrThrow4566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnName4567;
		public virtual global::java.lang.String getColumnName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.CursorWrapper._getColumnName4567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getColumnName4567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		public new global::java.lang.String[] ColumnNames
		{
			get
			{
				return getColumnNames();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNames4568;
		public virtual global::java.lang.String[] getColumnNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.CursorWrapper._getColumnNames4568)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getColumnNames4568)) as java.lang.String[];
		}
		public new int ColumnCount
		{
			get
			{
				return getColumnCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getColumnCount4569;
		public virtual int getColumnCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.CursorWrapper._getColumnCount4569);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getColumnCount4569);
		}
		internal static global::MonoJavaBridge.MethodId _getBlob4570;
		public virtual byte[] getBlob(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.CursorWrapper._getBlob4570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getBlob4570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _copyStringToBuffer4571;
		public virtual void copyStringToBuffer(int arg0, android.database.CharArrayBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CursorWrapper._copyStringToBuffer4571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._copyStringToBuffer4571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isNull4572;
		public virtual bool isNull(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper._isNull4572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._isNull4572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deactivate4573;
		public virtual void deactivate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CursorWrapper._deactivate4573);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._deactivate4573);
		}
		internal static global::MonoJavaBridge.MethodId _requery4574;
		public virtual bool requery() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper._requery4574);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._requery4574);
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver4575;
		public virtual void registerDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CursorWrapper._registerDataSetObserver4575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._registerDataSetObserver4575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterDataSetObserver4576;
		public virtual void unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CursorWrapper._unregisterDataSetObserver4576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._unregisterDataSetObserver4576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNotificationUri4577;
		public virtual void setNotificationUri(android.content.ContentResolver arg0, android.net.Uri arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.CursorWrapper._setNotificationUri4577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._setNotificationUri4577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new bool WantsAllOnMoveCalls
		{
			get
			{
				return getWantsAllOnMoveCalls();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWantsAllOnMoveCalls4578;
		public virtual bool getWantsAllOnMoveCalls() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper._getWantsAllOnMoveCalls4578);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getWantsAllOnMoveCalls4578);
		}
		internal static global::MonoJavaBridge.MethodId _respond4579;
		public virtual global::android.os.Bundle respond(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.CursorWrapper._respond4579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._respond4579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _CursorWrapper4580;
		public CursorWrapper(android.database.Cursor arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._CursorWrapper4580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.CursorWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/CursorWrapper"));
			global::android.database.CursorWrapper._getShort4542 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getShort", "(I)S");
			global::android.database.CursorWrapper._getInt4543 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getInt", "(I)I");
			global::android.database.CursorWrapper._getLong4544 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getLong", "(I)J");
			global::android.database.CursorWrapper._getFloat4545 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getFloat", "(I)F");
			global::android.database.CursorWrapper._getDouble4546 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getDouble", "(I)D");
			global::android.database.CursorWrapper._close4547 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "close", "()V");
			global::android.database.CursorWrapper._getString4548 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getString", "(I)Ljava/lang/String;");
			global::android.database.CursorWrapper._isFirst4549 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "isFirst", "()Z");
			global::android.database.CursorWrapper._isClosed4550 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "isClosed", "()Z");
			global::android.database.CursorWrapper._getPosition4551 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getPosition", "()I");
			global::android.database.CursorWrapper._getExtras4552 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getExtras", "()Landroid/os/Bundle;");
			global::android.database.CursorWrapper._registerContentObserver4553 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "registerContentObserver", "(Landroid/database/ContentObserver;)V");
			global::android.database.CursorWrapper._unregisterContentObserver4554 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "unregisterContentObserver", "(Landroid/database/ContentObserver;)V");
			global::android.database.CursorWrapper._getCount4555 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getCount", "()I");
			global::android.database.CursorWrapper._move4556 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "move", "(I)Z");
			global::android.database.CursorWrapper._moveToPosition4557 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "moveToPosition", "(I)Z");
			global::android.database.CursorWrapper._moveToFirst4558 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "moveToFirst", "()Z");
			global::android.database.CursorWrapper._moveToLast4559 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "moveToLast", "()Z");
			global::android.database.CursorWrapper._moveToNext4560 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "moveToNext", "()Z");
			global::android.database.CursorWrapper._moveToPrevious4561 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "moveToPrevious", "()Z");
			global::android.database.CursorWrapper._isLast4562 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "isLast", "()Z");
			global::android.database.CursorWrapper._isBeforeFirst4563 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "isBeforeFirst", "()Z");
			global::android.database.CursorWrapper._isAfterLast4564 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "isAfterLast", "()Z");
			global::android.database.CursorWrapper._getColumnIndex4565 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getColumnIndex", "(Ljava/lang/String;)I");
			global::android.database.CursorWrapper._getColumnIndexOrThrow4566 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getColumnIndexOrThrow", "(Ljava/lang/String;)I");
			global::android.database.CursorWrapper._getColumnName4567 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getColumnName", "(I)Ljava/lang/String;");
			global::android.database.CursorWrapper._getColumnNames4568 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getColumnNames", "()[Ljava/lang/String;");
			global::android.database.CursorWrapper._getColumnCount4569 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getColumnCount", "()I");
			global::android.database.CursorWrapper._getBlob4570 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getBlob", "(I)[B");
			global::android.database.CursorWrapper._copyStringToBuffer4571 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V");
			global::android.database.CursorWrapper._isNull4572 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "isNull", "(I)Z");
			global::android.database.CursorWrapper._deactivate4573 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "deactivate", "()V");
			global::android.database.CursorWrapper._requery4574 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "requery", "()Z");
			global::android.database.CursorWrapper._registerDataSetObserver4575 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.database.CursorWrapper._unregisterDataSetObserver4576 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.database.CursorWrapper._setNotificationUri4577 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V");
			global::android.database.CursorWrapper._getWantsAllOnMoveCalls4578 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getWantsAllOnMoveCalls", "()Z");
			global::android.database.CursorWrapper._respond4579 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;");
			global::android.database.CursorWrapper._CursorWrapper4580 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "<init>", "(Landroid/database/Cursor;)V");
		}
	}
}
