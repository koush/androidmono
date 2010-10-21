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
		internal static global::MonoJavaBridge.MethodId _getShort12412;
		public virtual short getShort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::android.test.mock.MockCursor._getShort12412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getShort12412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt12413;
		public virtual int getInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockCursor._getInt12413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getInt12413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong12414;
		public virtual long getLong(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.test.mock.MockCursor._getLong12414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getLong12414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat12415;
		public virtual float getFloat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.test.mock.MockCursor._getFloat12415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getFloat12415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble12416;
		public virtual double getDouble(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.test.mock.MockCursor._getDouble12416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getDouble12416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close12417;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor._close12417);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._close12417);
		}
		internal static global::MonoJavaBridge.MethodId _getString12418;
		public virtual global::java.lang.String getString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockCursor._getString12418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getString12418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isFirst12419;
		public virtual bool isFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._isFirst12419);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._isFirst12419);
		}
		internal static global::MonoJavaBridge.MethodId _isClosed12420;
		public virtual bool isClosed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._isClosed12420);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._isClosed12420);
		}
		public new int Position
		{
			get
			{
				return getPosition();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPosition12421;
		public virtual int getPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockCursor._getPosition12421);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getPosition12421);
		}
		public new global::android.os.Bundle Extras
		{
			get
			{
				return getExtras();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExtras12422;
		public virtual global::android.os.Bundle getExtras() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockCursor._getExtras12422)) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getExtras12422)) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _registerContentObserver12423;
		public virtual void registerContentObserver(android.database.ContentObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor._registerContentObserver12423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._registerContentObserver12423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterContentObserver12424;
		public virtual void unregisterContentObserver(android.database.ContentObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor._unregisterContentObserver12424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._unregisterContentObserver12424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Count
		{
			get
			{
				return getCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCount12425;
		public virtual int getCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockCursor._getCount12425);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getCount12425);
		}
		internal static global::MonoJavaBridge.MethodId _move12426;
		public virtual bool move(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._move12426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._move12426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveToPosition12427;
		public virtual bool moveToPosition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._moveToPosition12427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._moveToPosition12427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveToFirst12428;
		public virtual bool moveToFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._moveToFirst12428);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._moveToFirst12428);
		}
		internal static global::MonoJavaBridge.MethodId _moveToLast12429;
		public virtual bool moveToLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._moveToLast12429);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._moveToLast12429);
		}
		internal static global::MonoJavaBridge.MethodId _moveToNext12430;
		public virtual bool moveToNext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._moveToNext12430);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._moveToNext12430);
		}
		internal static global::MonoJavaBridge.MethodId _moveToPrevious12431;
		public virtual bool moveToPrevious() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._moveToPrevious12431);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._moveToPrevious12431);
		}
		internal static global::MonoJavaBridge.MethodId _isLast12432;
		public virtual bool isLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._isLast12432);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._isLast12432);
		}
		internal static global::MonoJavaBridge.MethodId _isBeforeFirst12433;
		public virtual bool isBeforeFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._isBeforeFirst12433);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._isBeforeFirst12433);
		}
		internal static global::MonoJavaBridge.MethodId _isAfterLast12434;
		public virtual bool isAfterLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._isAfterLast12434);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._isAfterLast12434);
		}
		internal static global::MonoJavaBridge.MethodId _getColumnIndex12435;
		public virtual int getColumnIndex(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockCursor._getColumnIndex12435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getColumnIndex12435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnIndexOrThrow12436;
		public virtual int getColumnIndexOrThrow(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockCursor._getColumnIndexOrThrow12436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getColumnIndexOrThrow12436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnName12437;
		public virtual global::java.lang.String getColumnName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockCursor._getColumnName12437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getColumnName12437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		public new global::java.lang.String[] ColumnNames
		{
			get
			{
				return getColumnNames();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNames12438;
		public virtual global::java.lang.String[] getColumnNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockCursor._getColumnNames12438)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getColumnNames12438)) as java.lang.String[];
		}
		public new int ColumnCount
		{
			get
			{
				return getColumnCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getColumnCount12439;
		public virtual int getColumnCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockCursor._getColumnCount12439);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getColumnCount12439);
		}
		internal static global::MonoJavaBridge.MethodId _getBlob12440;
		public virtual byte[] getBlob(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockCursor._getBlob12440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getBlob12440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _copyStringToBuffer12441;
		public virtual void copyStringToBuffer(int arg0, android.database.CharArrayBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor._copyStringToBuffer12441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._copyStringToBuffer12441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isNull12442;
		public virtual bool isNull(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._isNull12442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._isNull12442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deactivate12443;
		public virtual void deactivate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor._deactivate12443);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._deactivate12443);
		}
		internal static global::MonoJavaBridge.MethodId _requery12444;
		public virtual bool requery() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._requery12444);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._requery12444);
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver12445;
		public virtual void registerDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor._registerDataSetObserver12445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._registerDataSetObserver12445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterDataSetObserver12446;
		public virtual void unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor._unregisterDataSetObserver12446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._unregisterDataSetObserver12446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNotificationUri12447;
		public virtual void setNotificationUri(android.content.ContentResolver arg0, android.net.Uri arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor._setNotificationUri12447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._setNotificationUri12447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new bool WantsAllOnMoveCalls
		{
			get
			{
				return getWantsAllOnMoveCalls();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWantsAllOnMoveCalls12448;
		public virtual bool getWantsAllOnMoveCalls() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._getWantsAllOnMoveCalls12448);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getWantsAllOnMoveCalls12448);
		}
		internal static global::MonoJavaBridge.MethodId _respond12449;
		public virtual global::android.os.Bundle respond(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockCursor._respond12449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._respond12449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _commitUpdates12450;
		public virtual bool commitUpdates() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._commitUpdates12450);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._commitUpdates12450);
		}
		internal static global::MonoJavaBridge.MethodId _commitUpdates12451;
		public virtual bool commitUpdates(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._commitUpdates12451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._commitUpdates12451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasUpdates12452;
		public virtual bool hasUpdates() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._hasUpdates12452);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._hasUpdates12452);
		}
		internal static global::MonoJavaBridge.MethodId _supportsUpdates12453;
		public virtual bool supportsUpdates() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._supportsUpdates12453);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._supportsUpdates12453);
		}
		internal static global::MonoJavaBridge.MethodId _deleteRow12454;
		public virtual bool deleteRow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._deleteRow12454);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._deleteRow12454);
		}
		internal static global::MonoJavaBridge.MethodId _updateBlob12455;
		public virtual bool updateBlob(int arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._updateBlob12455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._updateBlob12455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateDouble12456;
		public virtual bool updateDouble(int arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._updateDouble12456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._updateDouble12456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateFloat12457;
		public virtual bool updateFloat(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._updateFloat12457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._updateFloat12457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateInt12458;
		public virtual bool updateInt(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._updateInt12458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._updateInt12458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateLong12459;
		public virtual bool updateLong(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._updateLong12459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._updateLong12459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateShort12460;
		public virtual bool updateShort(int arg0, short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._updateShort12460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._updateShort12460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateString12461;
		public virtual bool updateString(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._updateString12461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._updateString12461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateToNull12462;
		public virtual bool updateToNull(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._updateToNull12462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._updateToNull12462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _abortUpdates12463;
		public virtual void abortUpdates() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor._abortUpdates12463);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._abortUpdates12463);
		}
		internal static global::MonoJavaBridge.MethodId _MockCursor12464;
		public MockCursor()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._MockCursor12464);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.mock.MockCursor.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/mock/MockCursor"));
			global::android.test.mock.MockCursor._getShort12412 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getShort", "(I)S");
			global::android.test.mock.MockCursor._getInt12413 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getInt", "(I)I");
			global::android.test.mock.MockCursor._getLong12414 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getLong", "(I)J");
			global::android.test.mock.MockCursor._getFloat12415 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getFloat", "(I)F");
			global::android.test.mock.MockCursor._getDouble12416 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getDouble", "(I)D");
			global::android.test.mock.MockCursor._close12417 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "close", "()V");
			global::android.test.mock.MockCursor._getString12418 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getString", "(I)Ljava/lang/String;");
			global::android.test.mock.MockCursor._isFirst12419 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "isFirst", "()Z");
			global::android.test.mock.MockCursor._isClosed12420 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "isClosed", "()Z");
			global::android.test.mock.MockCursor._getPosition12421 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getPosition", "()I");
			global::android.test.mock.MockCursor._getExtras12422 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getExtras", "()Landroid/os/Bundle;");
			global::android.test.mock.MockCursor._registerContentObserver12423 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "registerContentObserver", "(Landroid/database/ContentObserver;)V");
			global::android.test.mock.MockCursor._unregisterContentObserver12424 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "unregisterContentObserver", "(Landroid/database/ContentObserver;)V");
			global::android.test.mock.MockCursor._getCount12425 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getCount", "()I");
			global::android.test.mock.MockCursor._move12426 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "move", "(I)Z");
			global::android.test.mock.MockCursor._moveToPosition12427 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "moveToPosition", "(I)Z");
			global::android.test.mock.MockCursor._moveToFirst12428 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "moveToFirst", "()Z");
			global::android.test.mock.MockCursor._moveToLast12429 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "moveToLast", "()Z");
			global::android.test.mock.MockCursor._moveToNext12430 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "moveToNext", "()Z");
			global::android.test.mock.MockCursor._moveToPrevious12431 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "moveToPrevious", "()Z");
			global::android.test.mock.MockCursor._isLast12432 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "isLast", "()Z");
			global::android.test.mock.MockCursor._isBeforeFirst12433 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "isBeforeFirst", "()Z");
			global::android.test.mock.MockCursor._isAfterLast12434 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "isAfterLast", "()Z");
			global::android.test.mock.MockCursor._getColumnIndex12435 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getColumnIndex", "(Ljava/lang/String;)I");
			global::android.test.mock.MockCursor._getColumnIndexOrThrow12436 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getColumnIndexOrThrow", "(Ljava/lang/String;)I");
			global::android.test.mock.MockCursor._getColumnName12437 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getColumnName", "(I)Ljava/lang/String;");
			global::android.test.mock.MockCursor._getColumnNames12438 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getColumnNames", "()[Ljava/lang/String;");
			global::android.test.mock.MockCursor._getColumnCount12439 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getColumnCount", "()I");
			global::android.test.mock.MockCursor._getBlob12440 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getBlob", "(I)[B");
			global::android.test.mock.MockCursor._copyStringToBuffer12441 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V");
			global::android.test.mock.MockCursor._isNull12442 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "isNull", "(I)Z");
			global::android.test.mock.MockCursor._deactivate12443 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "deactivate", "()V");
			global::android.test.mock.MockCursor._requery12444 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "requery", "()Z");
			global::android.test.mock.MockCursor._registerDataSetObserver12445 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.test.mock.MockCursor._unregisterDataSetObserver12446 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.test.mock.MockCursor._setNotificationUri12447 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V");
			global::android.test.mock.MockCursor._getWantsAllOnMoveCalls12448 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getWantsAllOnMoveCalls", "()Z");
			global::android.test.mock.MockCursor._respond12449 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;");
			global::android.test.mock.MockCursor._commitUpdates12450 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "commitUpdates", "()Z");
			global::android.test.mock.MockCursor._commitUpdates12451 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "commitUpdates", "(Ljava/util/Map;)Z");
			global::android.test.mock.MockCursor._hasUpdates12452 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "hasUpdates", "()Z");
			global::android.test.mock.MockCursor._supportsUpdates12453 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "supportsUpdates", "()Z");
			global::android.test.mock.MockCursor._deleteRow12454 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "deleteRow", "()Z");
			global::android.test.mock.MockCursor._updateBlob12455 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "updateBlob", "(I[B)Z");
			global::android.test.mock.MockCursor._updateDouble12456 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "updateDouble", "(ID)Z");
			global::android.test.mock.MockCursor._updateFloat12457 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "updateFloat", "(IF)Z");
			global::android.test.mock.MockCursor._updateInt12458 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "updateInt", "(II)Z");
			global::android.test.mock.MockCursor._updateLong12459 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "updateLong", "(IJ)Z");
			global::android.test.mock.MockCursor._updateShort12460 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "updateShort", "(IS)Z");
			global::android.test.mock.MockCursor._updateString12461 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "updateString", "(ILjava/lang/String;)Z");
			global::android.test.mock.MockCursor._updateToNull12462 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "updateToNull", "(I)Z");
			global::android.test.mock.MockCursor._abortUpdates12463 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "abortUpdates", "()V");
			global::android.test.mock.MockCursor._MockCursor12464 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "<init>", "()V");
		}
	}
}
