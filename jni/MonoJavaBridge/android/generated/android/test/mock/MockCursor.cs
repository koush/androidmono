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
		internal static global::MonoJavaBridge.MethodId _getShort7934;
		public virtual short getShort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::android.test.mock.MockCursor._getShort7934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getShort7934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt7935;
		public virtual int getInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockCursor._getInt7935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getInt7935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong7936;
		public virtual long getLong(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.test.mock.MockCursor._getLong7936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getLong7936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat7937;
		public virtual float getFloat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.test.mock.MockCursor._getFloat7937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getFloat7937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble7938;
		public virtual double getDouble(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.test.mock.MockCursor._getDouble7938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getDouble7938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close7939;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor._close7939);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._close7939);
		}
		internal static global::MonoJavaBridge.MethodId _getString7940;
		public virtual global::java.lang.String getString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockCursor._getString7940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getString7940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isFirst7941;
		public virtual bool isFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._isFirst7941);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._isFirst7941);
		}
		internal static global::MonoJavaBridge.MethodId _isClosed7942;
		public virtual bool isClosed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._isClosed7942);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._isClosed7942);
		}
		public new int Position
		{
			get
			{
				return getPosition();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPosition7943;
		public virtual int getPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockCursor._getPosition7943);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getPosition7943);
		}
		public new global::android.os.Bundle Extras
		{
			get
			{
				return getExtras();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExtras7944;
		public virtual global::android.os.Bundle getExtras() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockCursor._getExtras7944)) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getExtras7944)) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _registerContentObserver7945;
		public virtual void registerContentObserver(android.database.ContentObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor._registerContentObserver7945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._registerContentObserver7945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterContentObserver7946;
		public virtual void unregisterContentObserver(android.database.ContentObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor._unregisterContentObserver7946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._unregisterContentObserver7946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Count
		{
			get
			{
				return getCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCount7947;
		public virtual int getCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockCursor._getCount7947);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getCount7947);
		}
		internal static global::MonoJavaBridge.MethodId _move7948;
		public virtual bool move(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._move7948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._move7948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveToPosition7949;
		public virtual bool moveToPosition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._moveToPosition7949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._moveToPosition7949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveToFirst7950;
		public virtual bool moveToFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._moveToFirst7950);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._moveToFirst7950);
		}
		internal static global::MonoJavaBridge.MethodId _moveToLast7951;
		public virtual bool moveToLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._moveToLast7951);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._moveToLast7951);
		}
		internal static global::MonoJavaBridge.MethodId _moveToNext7952;
		public virtual bool moveToNext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._moveToNext7952);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._moveToNext7952);
		}
		internal static global::MonoJavaBridge.MethodId _moveToPrevious7953;
		public virtual bool moveToPrevious() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._moveToPrevious7953);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._moveToPrevious7953);
		}
		internal static global::MonoJavaBridge.MethodId _isLast7954;
		public virtual bool isLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._isLast7954);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._isLast7954);
		}
		internal static global::MonoJavaBridge.MethodId _isBeforeFirst7955;
		public virtual bool isBeforeFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._isBeforeFirst7955);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._isBeforeFirst7955);
		}
		internal static global::MonoJavaBridge.MethodId _isAfterLast7956;
		public virtual bool isAfterLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._isAfterLast7956);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._isAfterLast7956);
		}
		internal static global::MonoJavaBridge.MethodId _getColumnIndex7957;
		public virtual int getColumnIndex(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockCursor._getColumnIndex7957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getColumnIndex7957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnIndexOrThrow7958;
		public virtual int getColumnIndexOrThrow(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockCursor._getColumnIndexOrThrow7958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getColumnIndexOrThrow7958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnName7959;
		public virtual global::java.lang.String getColumnName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockCursor._getColumnName7959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getColumnName7959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		public new global::java.lang.String[] ColumnNames
		{
			get
			{
				return getColumnNames();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNames7960;
		public virtual global::java.lang.String[] getColumnNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockCursor._getColumnNames7960)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getColumnNames7960)) as java.lang.String[];
		}
		public new int ColumnCount
		{
			get
			{
				return getColumnCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getColumnCount7961;
		public virtual int getColumnCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.mock.MockCursor._getColumnCount7961);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getColumnCount7961);
		}
		internal static global::MonoJavaBridge.MethodId _getBlob7962;
		public virtual byte[] getBlob(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockCursor._getBlob7962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getBlob7962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _copyStringToBuffer7963;
		public virtual void copyStringToBuffer(int arg0, android.database.CharArrayBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor._copyStringToBuffer7963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._copyStringToBuffer7963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isNull7964;
		public virtual bool isNull(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._isNull7964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._isNull7964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deactivate7965;
		public virtual void deactivate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor._deactivate7965);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._deactivate7965);
		}
		internal static global::MonoJavaBridge.MethodId _requery7966;
		public virtual bool requery() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._requery7966);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._requery7966);
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver7967;
		public virtual void registerDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor._registerDataSetObserver7967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._registerDataSetObserver7967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterDataSetObserver7968;
		public virtual void unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor._unregisterDataSetObserver7968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._unregisterDataSetObserver7968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNotificationUri7969;
		public virtual void setNotificationUri(android.content.ContentResolver arg0, android.net.Uri arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor._setNotificationUri7969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._setNotificationUri7969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new bool WantsAllOnMoveCalls
		{
			get
			{
				return getWantsAllOnMoveCalls();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWantsAllOnMoveCalls7970;
		public virtual bool getWantsAllOnMoveCalls() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._getWantsAllOnMoveCalls7970);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._getWantsAllOnMoveCalls7970);
		}
		internal static global::MonoJavaBridge.MethodId _respond7971;
		public virtual global::android.os.Bundle respond(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.mock.MockCursor._respond7971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._respond7971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _commitUpdates7972;
		public virtual bool commitUpdates() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._commitUpdates7972);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._commitUpdates7972);
		}
		internal static global::MonoJavaBridge.MethodId _commitUpdates7973;
		public virtual bool commitUpdates(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._commitUpdates7973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._commitUpdates7973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hasUpdates7974;
		public virtual bool hasUpdates() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._hasUpdates7974);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._hasUpdates7974);
		}
		internal static global::MonoJavaBridge.MethodId _supportsUpdates7975;
		public virtual bool supportsUpdates() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._supportsUpdates7975);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._supportsUpdates7975);
		}
		internal static global::MonoJavaBridge.MethodId _deleteRow7976;
		public virtual bool deleteRow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._deleteRow7976);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._deleteRow7976);
		}
		internal static global::MonoJavaBridge.MethodId _updateBlob7977;
		public virtual bool updateBlob(int arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._updateBlob7977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._updateBlob7977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateDouble7978;
		public virtual bool updateDouble(int arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._updateDouble7978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._updateDouble7978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateFloat7979;
		public virtual bool updateFloat(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._updateFloat7979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._updateFloat7979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateInt7980;
		public virtual bool updateInt(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._updateInt7980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._updateInt7980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateLong7981;
		public virtual bool updateLong(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._updateLong7981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._updateLong7981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateShort7982;
		public virtual bool updateShort(int arg0, short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._updateShort7982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._updateShort7982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateString7983;
		public virtual bool updateString(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._updateString7983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._updateString7983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateToNull7984;
		public virtual bool updateToNull(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor._updateToNull7984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._updateToNull7984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _abortUpdates7985;
		public virtual void abortUpdates() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor._abortUpdates7985);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._abortUpdates7985);
		}
		internal static global::MonoJavaBridge.MethodId _MockCursor7986;
		public MockCursor()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.mock.MockCursor.staticClass, global::android.test.mock.MockCursor._MockCursor7986);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.mock.MockCursor.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/mock/MockCursor"));
			global::android.test.mock.MockCursor._getShort7934 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getShort", "(I)S");
			global::android.test.mock.MockCursor._getInt7935 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getInt", "(I)I");
			global::android.test.mock.MockCursor._getLong7936 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getLong", "(I)J");
			global::android.test.mock.MockCursor._getFloat7937 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getFloat", "(I)F");
			global::android.test.mock.MockCursor._getDouble7938 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getDouble", "(I)D");
			global::android.test.mock.MockCursor._close7939 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "close", "()V");
			global::android.test.mock.MockCursor._getString7940 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getString", "(I)Ljava/lang/String;");
			global::android.test.mock.MockCursor._isFirst7941 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "isFirst", "()Z");
			global::android.test.mock.MockCursor._isClosed7942 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "isClosed", "()Z");
			global::android.test.mock.MockCursor._getPosition7943 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getPosition", "()I");
			global::android.test.mock.MockCursor._getExtras7944 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getExtras", "()Landroid/os/Bundle;");
			global::android.test.mock.MockCursor._registerContentObserver7945 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "registerContentObserver", "(Landroid/database/ContentObserver;)V");
			global::android.test.mock.MockCursor._unregisterContentObserver7946 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "unregisterContentObserver", "(Landroid/database/ContentObserver;)V");
			global::android.test.mock.MockCursor._getCount7947 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getCount", "()I");
			global::android.test.mock.MockCursor._move7948 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "move", "(I)Z");
			global::android.test.mock.MockCursor._moveToPosition7949 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "moveToPosition", "(I)Z");
			global::android.test.mock.MockCursor._moveToFirst7950 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "moveToFirst", "()Z");
			global::android.test.mock.MockCursor._moveToLast7951 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "moveToLast", "()Z");
			global::android.test.mock.MockCursor._moveToNext7952 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "moveToNext", "()Z");
			global::android.test.mock.MockCursor._moveToPrevious7953 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "moveToPrevious", "()Z");
			global::android.test.mock.MockCursor._isLast7954 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "isLast", "()Z");
			global::android.test.mock.MockCursor._isBeforeFirst7955 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "isBeforeFirst", "()Z");
			global::android.test.mock.MockCursor._isAfterLast7956 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "isAfterLast", "()Z");
			global::android.test.mock.MockCursor._getColumnIndex7957 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getColumnIndex", "(Ljava/lang/String;)I");
			global::android.test.mock.MockCursor._getColumnIndexOrThrow7958 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getColumnIndexOrThrow", "(Ljava/lang/String;)I");
			global::android.test.mock.MockCursor._getColumnName7959 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getColumnName", "(I)Ljava/lang/String;");
			global::android.test.mock.MockCursor._getColumnNames7960 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getColumnNames", "()[Ljava/lang/String;");
			global::android.test.mock.MockCursor._getColumnCount7961 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getColumnCount", "()I");
			global::android.test.mock.MockCursor._getBlob7962 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getBlob", "(I)[B");
			global::android.test.mock.MockCursor._copyStringToBuffer7963 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V");
			global::android.test.mock.MockCursor._isNull7964 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "isNull", "(I)Z");
			global::android.test.mock.MockCursor._deactivate7965 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "deactivate", "()V");
			global::android.test.mock.MockCursor._requery7966 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "requery", "()Z");
			global::android.test.mock.MockCursor._registerDataSetObserver7967 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.test.mock.MockCursor._unregisterDataSetObserver7968 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.test.mock.MockCursor._setNotificationUri7969 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V");
			global::android.test.mock.MockCursor._getWantsAllOnMoveCalls7970 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "getWantsAllOnMoveCalls", "()Z");
			global::android.test.mock.MockCursor._respond7971 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;");
			global::android.test.mock.MockCursor._commitUpdates7972 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "commitUpdates", "()Z");
			global::android.test.mock.MockCursor._commitUpdates7973 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "commitUpdates", "(Ljava/util/Map;)Z");
			global::android.test.mock.MockCursor._hasUpdates7974 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "hasUpdates", "()Z");
			global::android.test.mock.MockCursor._supportsUpdates7975 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "supportsUpdates", "()Z");
			global::android.test.mock.MockCursor._deleteRow7976 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "deleteRow", "()Z");
			global::android.test.mock.MockCursor._updateBlob7977 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "updateBlob", "(I[B)Z");
			global::android.test.mock.MockCursor._updateDouble7978 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "updateDouble", "(ID)Z");
			global::android.test.mock.MockCursor._updateFloat7979 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "updateFloat", "(IF)Z");
			global::android.test.mock.MockCursor._updateInt7980 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "updateInt", "(II)Z");
			global::android.test.mock.MockCursor._updateLong7981 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "updateLong", "(IJ)Z");
			global::android.test.mock.MockCursor._updateShort7982 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "updateShort", "(IS)Z");
			global::android.test.mock.MockCursor._updateString7983 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "updateString", "(ILjava/lang/String;)Z");
			global::android.test.mock.MockCursor._updateToNull7984 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "updateToNull", "(I)Z");
			global::android.test.mock.MockCursor._abortUpdates7985 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "abortUpdates", "()V");
			global::android.test.mock.MockCursor._MockCursor7986 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockCursor.staticClass, "<init>", "()V");
		}
	}
}
