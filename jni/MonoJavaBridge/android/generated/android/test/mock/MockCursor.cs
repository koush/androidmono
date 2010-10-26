namespace android.test.mock
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MockCursor : java.lang.Object, android.database.Cursor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MockCursor()
		{
			InitJNI();
		}
		protected MockCursor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getShort12470;
		public virtual short getShort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::android.test.mock.MockCursor._getShort12470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getShort12470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt12471;
		public virtual int getInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockCursor._getInt12471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getInt12471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong12472;
		public virtual long getLong(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.test.mock.MockCursor._getLong12472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getLong12472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat12473;
		public virtual float getFloat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.test.mock.MockCursor._getFloat12473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getFloat12473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble12474;
		public virtual double getDouble(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.test.mock.MockCursor._getDouble12474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getDouble12474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close12475;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor._close12475);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._close12475);
		}
		internal static global::MonoJavaBridge.MethodId _getString12476;
		public virtual global::java.lang.String getString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockCursor._getString12476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getString12476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isFirst12477;
		public virtual bool isFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._isFirst12477);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._isFirst12477);
		}
		internal static global::MonoJavaBridge.MethodId _isClosed12478;
		public virtual bool isClosed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._isClosed12478);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._isClosed12478);
		}
		public new int Position
		{
			get
			{
				return getPosition();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPosition12479;
		public virtual int getPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockCursor._getPosition12479);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getPosition12479);
		}
		public new global::android.os.Bundle Extras
		{
			get
			{
				return getExtras();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExtras12480;
		public virtual global::android.os.Bundle getExtras() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockCursor._getExtras12480)) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getExtras12480)) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _registerContentObserver12481;
		public virtual void registerContentObserver(android.database.ContentObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor._registerContentObserver12481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._registerContentObserver12481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterContentObserver12482;
		public virtual void unregisterContentObserver(android.database.ContentObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor._unregisterContentObserver12482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._unregisterContentObserver12482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Count
		{
			get
			{
				return getCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCount12483;
		public virtual int getCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockCursor._getCount12483);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getCount12483);
		}
		internal static global::MonoJavaBridge.MethodId _move12484;
		public virtual bool move(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._move12484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._move12484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveToPosition12485;
		public virtual bool moveToPosition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._moveToPosition12485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._moveToPosition12485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveToFirst12486;
		public virtual bool moveToFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._moveToFirst12486);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._moveToFirst12486);
		}
		internal static global::MonoJavaBridge.MethodId _moveToLast12487;
		public virtual bool moveToLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._moveToLast12487);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._moveToLast12487);
		}
		internal static global::MonoJavaBridge.MethodId _moveToNext12488;
		public virtual bool moveToNext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._moveToNext12488);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._moveToNext12488);
		}
		internal static global::MonoJavaBridge.MethodId _moveToPrevious12489;
		public virtual bool moveToPrevious() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._moveToPrevious12489);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._moveToPrevious12489);
		}
		internal static global::MonoJavaBridge.MethodId _isLast12490;
		public virtual bool isLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._isLast12490);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._isLast12490);
		}
		internal static global::MonoJavaBridge.MethodId _isBeforeFirst12491;
		public virtual bool isBeforeFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._isBeforeFirst12491);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._isBeforeFirst12491);
		}
		internal static global::MonoJavaBridge.MethodId _isAfterLast12492;
		public virtual bool isAfterLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._isAfterLast12492);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._isAfterLast12492);
		}
		internal static global::MonoJavaBridge.MethodId _getColumnIndex12493;
		public virtual int getColumnIndex(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockCursor._getColumnIndex12493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getColumnIndex12493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnIndexOrThrow12494;
		public virtual int getColumnIndexOrThrow(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockCursor._getColumnIndexOrThrow12494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getColumnIndexOrThrow12494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnName12495;
		public virtual global::java.lang.String getColumnName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockCursor._getColumnName12495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getColumnName12495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		public new global::java.lang.String[] ColumnNames
		{
			get
			{
				return getColumnNames();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNames12496;
		public virtual global::java.lang.String[] getColumnNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockCursor._getColumnNames12496)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getColumnNames12496)) as java.lang.String[];
		}
		public new int ColumnCount
		{
			get
			{
				return getColumnCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getColumnCount12497;
		public virtual int getColumnCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockCursor._getColumnCount12497);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getColumnCount12497);
		}
		internal static global::MonoJavaBridge.MethodId _getBlob12498;
		public virtual byte[] getBlob(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockCursor._getBlob12498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getBlob12498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _copyStringToBuffer12499;
		public virtual void copyStringToBuffer(int arg0, android.database.CharArrayBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor._copyStringToBuffer12499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._copyStringToBuffer12499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isNull12500;
		public virtual bool isNull(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._isNull12500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._isNull12500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deactivate12501;
		public virtual void deactivate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor._deactivate12501);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._deactivate12501);
		}
		internal static global::MonoJavaBridge.MethodId _requery12502;
		public virtual bool requery() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._requery12502);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._requery12502);
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver12503;
		public virtual void registerDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor._registerDataSetObserver12503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._registerDataSetObserver12503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterDataSetObserver12504;
		public virtual void unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor._unregisterDataSetObserver12504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._unregisterDataSetObserver12504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNotificationUri12505;
		public virtual void setNotificationUri(android.content.ContentResolver arg0, android.net.Uri arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor._setNotificationUri12505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._setNotificationUri12505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new bool WantsAllOnMoveCalls
		{
			get
			{
				return getWantsAllOnMoveCalls();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWantsAllOnMoveCalls12506;
		public virtual bool getWantsAllOnMoveCalls() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._getWantsAllOnMoveCalls12506);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getWantsAllOnMoveCalls12506);
		}
		internal static global::MonoJavaBridge.MethodId _respond12507;
		public virtual global::android.os.Bundle respond(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockCursor._respond12507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._respond12507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _commitUpdates12508;
		public virtual bool commitUpdates() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._commitUpdates12508);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._commitUpdates12508);
		}
		internal static global::MonoJavaBridge.MethodId _commitUpdates12509;
		public virtual bool commitUpdates(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._commitUpdates12509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._commitUpdates12509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasUpdates12510;
		public virtual bool hasUpdates() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._hasUpdates12510);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._hasUpdates12510);
		}
		internal static global::MonoJavaBridge.MethodId _supportsUpdates12511;
		public virtual bool supportsUpdates() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._supportsUpdates12511);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._supportsUpdates12511);
		}
		internal static global::MonoJavaBridge.MethodId _deleteRow12512;
		public virtual bool deleteRow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._deleteRow12512);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._deleteRow12512);
		}
		internal static global::MonoJavaBridge.MethodId _updateBlob12513;
		public virtual bool updateBlob(int arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._updateBlob12513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._updateBlob12513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateDouble12514;
		public virtual bool updateDouble(int arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._updateDouble12514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._updateDouble12514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateFloat12515;
		public virtual bool updateFloat(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._updateFloat12515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._updateFloat12515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateInt12516;
		public virtual bool updateInt(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._updateInt12516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._updateInt12516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateLong12517;
		public virtual bool updateLong(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._updateLong12517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._updateLong12517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateShort12518;
		public virtual bool updateShort(int arg0, short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._updateShort12518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._updateShort12518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateString12519;
		public virtual bool updateString(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._updateString12519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._updateString12519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateToNull12520;
		public virtual bool updateToNull(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._updateToNull12520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._updateToNull12520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _abortUpdates12521;
		public virtual void abortUpdates() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor._abortUpdates12521);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._abortUpdates12521);
		}
		internal static global::MonoJavaBridge.MethodId _MockCursor12522;
		public MockCursor()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._MockCursor12522);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.mock.MockCursor.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/mock/MockCursor"));
			global::android.test.mock.MockCursor._getShort12470 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getShort", "(I)S");
			global::android.test.mock.MockCursor._getInt12471 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getInt", "(I)I");
			global::android.test.mock.MockCursor._getLong12472 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getLong", "(I)J");
			global::android.test.mock.MockCursor._getFloat12473 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getFloat", "(I)F");
			global::android.test.mock.MockCursor._getDouble12474 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getDouble", "(I)D");
			global::android.test.mock.MockCursor._close12475 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "close", "()V");
			global::android.test.mock.MockCursor._getString12476 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getString", "(I)Ljava/lang/String;");
			global::android.test.mock.MockCursor._isFirst12477 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "isFirst", "()Z");
			global::android.test.mock.MockCursor._isClosed12478 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "isClosed", "()Z");
			global::android.test.mock.MockCursor._getPosition12479 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getPosition", "()I");
			global::android.test.mock.MockCursor._getExtras12480 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getExtras", "()Landroid/os/Bundle;");
			global::android.test.mock.MockCursor._registerContentObserver12481 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "registerContentObserver", "(Landroid/database/ContentObserver;)V");
			global::android.test.mock.MockCursor._unregisterContentObserver12482 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "unregisterContentObserver", "(Landroid/database/ContentObserver;)V");
			global::android.test.mock.MockCursor._getCount12483 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getCount", "()I");
			global::android.test.mock.MockCursor._move12484 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "move", "(I)Z");
			global::android.test.mock.MockCursor._moveToPosition12485 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "moveToPosition", "(I)Z");
			global::android.test.mock.MockCursor._moveToFirst12486 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "moveToFirst", "()Z");
			global::android.test.mock.MockCursor._moveToLast12487 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "moveToLast", "()Z");
			global::android.test.mock.MockCursor._moveToNext12488 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "moveToNext", "()Z");
			global::android.test.mock.MockCursor._moveToPrevious12489 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "moveToPrevious", "()Z");
			global::android.test.mock.MockCursor._isLast12490 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "isLast", "()Z");
			global::android.test.mock.MockCursor._isBeforeFirst12491 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "isBeforeFirst", "()Z");
			global::android.test.mock.MockCursor._isAfterLast12492 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "isAfterLast", "()Z");
			global::android.test.mock.MockCursor._getColumnIndex12493 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getColumnIndex", "(Ljava/lang/String;)I");
			global::android.test.mock.MockCursor._getColumnIndexOrThrow12494 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getColumnIndexOrThrow", "(Ljava/lang/String;)I");
			global::android.test.mock.MockCursor._getColumnName12495 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getColumnName", "(I)Ljava/lang/String;");
			global::android.test.mock.MockCursor._getColumnNames12496 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getColumnNames", "()[Ljava/lang/String;");
			global::android.test.mock.MockCursor._getColumnCount12497 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getColumnCount", "()I");
			global::android.test.mock.MockCursor._getBlob12498 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getBlob", "(I)[B");
			global::android.test.mock.MockCursor._copyStringToBuffer12499 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V");
			global::android.test.mock.MockCursor._isNull12500 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "isNull", "(I)Z");
			global::android.test.mock.MockCursor._deactivate12501 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "deactivate", "()V");
			global::android.test.mock.MockCursor._requery12502 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "requery", "()Z");
			global::android.test.mock.MockCursor._registerDataSetObserver12503 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.test.mock.MockCursor._unregisterDataSetObserver12504 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.test.mock.MockCursor._setNotificationUri12505 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V");
			global::android.test.mock.MockCursor._getWantsAllOnMoveCalls12506 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getWantsAllOnMoveCalls", "()Z");
			global::android.test.mock.MockCursor._respond12507 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;");
			global::android.test.mock.MockCursor._commitUpdates12508 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "commitUpdates", "()Z");
			global::android.test.mock.MockCursor._commitUpdates12509 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "commitUpdates", "(Ljava/util/Map;)Z");
			global::android.test.mock.MockCursor._hasUpdates12510 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "hasUpdates", "()Z");
			global::android.test.mock.MockCursor._supportsUpdates12511 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "supportsUpdates", "()Z");
			global::android.test.mock.MockCursor._deleteRow12512 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "deleteRow", "()Z");
			global::android.test.mock.MockCursor._updateBlob12513 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "updateBlob", "(I[B)Z");
			global::android.test.mock.MockCursor._updateDouble12514 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "updateDouble", "(ID)Z");
			global::android.test.mock.MockCursor._updateFloat12515 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "updateFloat", "(IF)Z");
			global::android.test.mock.MockCursor._updateInt12516 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "updateInt", "(II)Z");
			global::android.test.mock.MockCursor._updateLong12517 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "updateLong", "(IJ)Z");
			global::android.test.mock.MockCursor._updateShort12518 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "updateShort", "(IS)Z");
			global::android.test.mock.MockCursor._updateString12519 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "updateString", "(ILjava/lang/String;)Z");
			global::android.test.mock.MockCursor._updateToNull12520 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "updateToNull", "(I)Z");
			global::android.test.mock.MockCursor._abortUpdates12521 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "abortUpdates", "()V");
			global::android.test.mock.MockCursor._MockCursor12522 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "<init>", "()V");
		}
	}
}
