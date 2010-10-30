namespace android.database
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CursorWindow : android.database.sqlite.SQLiteClosable, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CursorWindow(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize4526;
		protected override void finalize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWindow._finalize4526.native == global::System.IntPtr.Zero)
				global::android.database.CursorWindow._finalize4526 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "finalize", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._finalize4526);
		}
		internal static global::MonoJavaBridge.MethodId _getShort4527;
		public virtual short getShort(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWindow._getShort4527.native == global::System.IntPtr.Zero)
				global::android.database.CursorWindow._getShort4527 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "getShort", "(II)S");
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._getShort4527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getInt4528;
		public virtual int getInt(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWindow._getInt4528.native == global::System.IntPtr.Zero)
				global::android.database.CursorWindow._getInt4528 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "getInt", "(II)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._getInt4528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getLong4529;
		public virtual long getLong(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWindow._getLong4529.native == global::System.IntPtr.Zero)
				global::android.database.CursorWindow._getLong4529 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "getLong", "(II)J");
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._getLong4529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putLong4530;
		public virtual bool putLong(long arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWindow._putLong4530.native == global::System.IntPtr.Zero)
				global::android.database.CursorWindow._putLong4530 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "putLong", "(JII)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._putLong4530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat4531;
		public virtual float getFloat(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWindow._getFloat4531.native == global::System.IntPtr.Zero)
				global::android.database.CursorWindow._getFloat4531 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "getFloat", "(II)F");
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._getFloat4531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble4532;
		public virtual double getDouble(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWindow._getDouble4532.native == global::System.IntPtr.Zero)
				global::android.database.CursorWindow._getDouble4532 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "getDouble", "(II)D");
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._getDouble4532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putDouble4533;
		public virtual bool putDouble(double arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWindow._putDouble4533.native == global::System.IntPtr.Zero)
				global::android.database.CursorWindow._putDouble4533 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "putDouble", "(DII)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._putDouble4533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _clear4534;
		public virtual void clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWindow._clear4534.native == global::System.IntPtr.Zero)
				global::android.database.CursorWindow._clear4534 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "clear", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._clear4534);
		}
		internal static global::MonoJavaBridge.MethodId _close4535;
		public virtual void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWindow._close4535.native == global::System.IntPtr.Zero)
				global::android.database.CursorWindow._close4535 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "close", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._close4535);
		}
		internal static global::MonoJavaBridge.MethodId _getString4536;
		public virtual global::java.lang.String getString(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWindow._getString4536.native == global::System.IntPtr.Zero)
				global::android.database.CursorWindow._getString4536 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "getString", "(II)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._getString4536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _putNull4537;
		public virtual bool putNull(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWindow._putNull4537.native == global::System.IntPtr.Zero)
				global::android.database.CursorWindow._putNull4537 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "putNull", "(II)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._putNull4537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel4538;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWindow._writeToParcel4538.native == global::System.IntPtr.Zero)
				global::android.database.CursorWindow._writeToParcel4538 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._writeToParcel4538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents4539;
		public virtual int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWindow._describeContents4539.native == global::System.IntPtr.Zero)
				global::android.database.CursorWindow._describeContents4539 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "describeContents", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._describeContents4539);
		}
		internal static global::MonoJavaBridge.MethodId _onAllReferencesReleased4540;
		protected override void onAllReferencesReleased()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWindow._onAllReferencesReleased4540.native == global::System.IntPtr.Zero)
				global::android.database.CursorWindow._onAllReferencesReleased4540 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "onAllReferencesReleased", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._onAllReferencesReleased4540);
		}
		internal static global::MonoJavaBridge.MethodId _putString4541;
		public virtual bool putString(java.lang.String arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWindow._putString4541.native == global::System.IntPtr.Zero)
				global::android.database.CursorWindow._putString4541 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "putString", "(Ljava/lang/String;II)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._putString4541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getBlob4542;
		public virtual byte[] getBlob(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWindow._getBlob4542.native == global::System.IntPtr.Zero)
				global::android.database.CursorWindow._getBlob4542 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "getBlob", "(II)[B");
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._getBlob4542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _copyStringToBuffer4543;
		public virtual void copyStringToBuffer(int arg0, int arg1, android.database.CharArrayBuffer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWindow._copyStringToBuffer4543.native == global::System.IntPtr.Zero)
				global::android.database.CursorWindow._copyStringToBuffer4543 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "copyStringToBuffer", "(IILandroid/database/CharArrayBuffer;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._copyStringToBuffer4543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isNull4544;
		public virtual bool isNull(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWindow._isNull4544.native == global::System.IntPtr.Zero)
				global::android.database.CursorWindow._isNull4544 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "isNull", "(II)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._isNull4544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int StartPosition
		{
			get
			{
				return getStartPosition();
			}
			set
			{
				setStartPosition(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStartPosition4545;
		public virtual int getStartPosition()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWindow._getStartPosition4545.native == global::System.IntPtr.Zero)
				global::android.database.CursorWindow._getStartPosition4545 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "getStartPosition", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._getStartPosition4545);
		}
		internal static global::MonoJavaBridge.MethodId _setStartPosition4546;
		public virtual void setStartPosition(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWindow._setStartPosition4546.native == global::System.IntPtr.Zero)
				global::android.database.CursorWindow._setStartPosition4546 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "setStartPosition", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._setStartPosition4546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int NumRows
		{
			get
			{
				return getNumRows();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNumRows4547;
		public virtual int getNumRows()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWindow._getNumRows4547.native == global::System.IntPtr.Zero)
				global::android.database.CursorWindow._getNumRows4547 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "getNumRows", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._getNumRows4547);
		}
		public new int NumColumns
		{
			set
			{
				setNumColumns(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setNumColumns4548;
		public virtual bool setNumColumns(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWindow._setNumColumns4548.native == global::System.IntPtr.Zero)
				global::android.database.CursorWindow._setNumColumns4548 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "setNumColumns", "(I)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._setNumColumns4548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _allocRow4549;
		public virtual bool allocRow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWindow._allocRow4549.native == global::System.IntPtr.Zero)
				global::android.database.CursorWindow._allocRow4549 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "allocRow", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._allocRow4549);
		}
		internal static global::MonoJavaBridge.MethodId _freeLastRow4550;
		public virtual void freeLastRow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWindow._freeLastRow4550.native == global::System.IntPtr.Zero)
				global::android.database.CursorWindow._freeLastRow4550 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "freeLastRow", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._freeLastRow4550);
		}
		internal static global::MonoJavaBridge.MethodId _putBlob4551;
		public virtual bool putBlob(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWindow._putBlob4551.native == global::System.IntPtr.Zero)
				global::android.database.CursorWindow._putBlob4551 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "putBlob", "([BII)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._putBlob4551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isBlob4552;
		public virtual bool isBlob(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWindow._isBlob4552.native == global::System.IntPtr.Zero)
				global::android.database.CursorWindow._isBlob4552 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "isBlob", "(II)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._isBlob4552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isLong4553;
		public virtual bool isLong(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWindow._isLong4553.native == global::System.IntPtr.Zero)
				global::android.database.CursorWindow._isLong4553 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "isLong", "(II)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._isLong4553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isFloat4554;
		public virtual bool isFloat(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWindow._isFloat4554.native == global::System.IntPtr.Zero)
				global::android.database.CursorWindow._isFloat4554 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "isFloat", "(II)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._isFloat4554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isString4555;
		public virtual bool isString(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWindow._isString4555.native == global::System.IntPtr.Zero)
				global::android.database.CursorWindow._isString4555 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "isString", "(II)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWindow.staticClass, global::android.database.CursorWindow._isString4555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _newFromParcel4556;
		public static global::android.database.CursorWindow newFromParcel(android.os.Parcel arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWindow._newFromParcel4556.native == global::System.IntPtr.Zero)
				global::android.database.CursorWindow._newFromParcel4556 = @__env.GetStaticMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "newFromParcel", "(Landroid/os/Parcel;)Landroid/database/CursorWindow;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.database.CursorWindow.staticClass, global::android.database.CursorWindow._newFromParcel4556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.CursorWindow;
		}
		internal static global::MonoJavaBridge.MethodId _CursorWindow4557;
		public CursorWindow(bool arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWindow._CursorWindow4557.native == global::System.IntPtr.Zero)
				global::android.database.CursorWindow._CursorWindow4557 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "<init>", "(Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.CursorWindow.staticClass, global::android.database.CursorWindow._CursorWindow4557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR4558;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.database.CursorWindow.staticClass, _CREATOR4558)) as android.os.Parcelable_Creator;
			}
		}
		static CursorWindow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.CursorWindow.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/CursorWindow"));
			global::android.database.CursorWindow._CREATOR4558 = @__env.GetStaticFieldIDNoThrow(global::android.database.CursorWindow.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
