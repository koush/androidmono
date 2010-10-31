namespace android.database
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CursorWindow : android.database.sqlite.SQLiteClosable, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CursorWindow(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CursorWindow.staticClass, "finalize", "()V", ref global::android.database.CursorWindow._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual short getShort(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::android.database.CursorWindow.staticClass, "getShort", "(II)S", ref global::android.database.CursorWindow._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int getInt(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.CursorWindow.staticClass, "getInt", "(II)I", ref global::android.database.CursorWindow._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual long getLong(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.database.CursorWindow.staticClass, "getLong", "(II)J", ref global::android.database.CursorWindow._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual bool putLong(long arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWindow.staticClass, "putLong", "(JII)Z", ref global::android.database.CursorWindow._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual float getFloat(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.database.CursorWindow.staticClass, "getFloat", "(II)F", ref global::android.database.CursorWindow._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual double getDouble(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::android.database.CursorWindow.staticClass, "getDouble", "(II)D", ref global::android.database.CursorWindow._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool putDouble(double arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWindow.staticClass, "putDouble", "(DII)Z", ref global::android.database.CursorWindow._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CursorWindow.staticClass, "clear", "()V", ref global::android.database.CursorWindow._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CursorWindow.staticClass, "close", "()V", ref global::android.database.CursorWindow._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::java.lang.String getString(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.database.CursorWindow.staticClass, "getString", "(II)Ljava/lang/String;", ref global::android.database.CursorWindow._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual bool putNull(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWindow.staticClass, "putNull", "(II)Z", ref global::android.database.CursorWindow._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CursorWindow.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.database.CursorWindow._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.CursorWindow.staticClass, "describeContents", "()I", ref global::android.database.CursorWindow._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		protected override void onAllReferencesReleased()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CursorWindow.staticClass, "onAllReferencesReleased", "()V", ref global::android.database.CursorWindow._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual bool putString(java.lang.String arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWindow.staticClass, "putString", "(Ljava/lang/String;II)Z", ref global::android.database.CursorWindow._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual byte[] getBlob(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::android.database.CursorWindow.staticClass, "getBlob", "(II)[B", ref global::android.database.CursorWindow._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void copyStringToBuffer(int arg0, int arg1, android.database.CharArrayBuffer arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CursorWindow.staticClass, "copyStringToBuffer", "(IILandroid/database/CharArrayBuffer;)V", ref global::android.database.CursorWindow._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual bool isNull(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWindow.staticClass, "isNull", "(II)Z", ref global::android.database.CursorWindow._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual int getStartPosition()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.CursorWindow.staticClass, "getStartPosition", "()I", ref global::android.database.CursorWindow._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void setStartPosition(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CursorWindow.staticClass, "setStartPosition", "(I)V", ref global::android.database.CursorWindow._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int NumRows
		{
			get
			{
				return getNumRows();
			}
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual int getNumRows()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.CursorWindow.staticClass, "getNumRows", "()I", ref global::android.database.CursorWindow._m21);
		}
		public new int NumColumns
		{
			set
			{
				setNumColumns(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual bool setNumColumns(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWindow.staticClass, "setNumColumns", "(I)Z", ref global::android.database.CursorWindow._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual bool allocRow()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWindow.staticClass, "allocRow", "()Z", ref global::android.database.CursorWindow._m23);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual void freeLastRow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CursorWindow.staticClass, "freeLastRow", "()V", ref global::android.database.CursorWindow._m24);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual bool putBlob(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWindow.staticClass, "putBlob", "([BII)Z", ref global::android.database.CursorWindow._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual bool isBlob(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWindow.staticClass, "isBlob", "(II)Z", ref global::android.database.CursorWindow._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual bool isLong(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWindow.staticClass, "isLong", "(II)Z", ref global::android.database.CursorWindow._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual bool isFloat(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWindow.staticClass, "isFloat", "(II)Z", ref global::android.database.CursorWindow._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual bool isString(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWindow.staticClass, "isString", "(II)Z", ref global::android.database.CursorWindow._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public static global::android.database.CursorWindow newFromParcel(android.os.Parcel arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWindow._m30.native == global::System.IntPtr.Zero)
				global::android.database.CursorWindow._m30 = @__env.GetStaticMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "newFromParcel", "(Landroid/os/Parcel;)Landroid/database/CursorWindow;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.database.CursorWindow.staticClass, global::android.database.CursorWindow._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.CursorWindow;
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public CursorWindow(bool arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWindow._m31.native == global::System.IntPtr.Zero)
				global::android.database.CursorWindow._m31 = @__env.GetMethodIDNoThrow(global::android.database.CursorWindow.staticClass, "<init>", "(Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.CursorWindow.staticClass, global::android.database.CursorWindow._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2199;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.database.CursorWindow.staticClass, _CREATOR2199)) as android.os.Parcelable_Creator;
			}
		}
		static CursorWindow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.CursorWindow.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/CursorWindow"));
			global::android.database.CursorWindow._CREATOR2199 = @__env.GetStaticFieldIDNoThrow(global::android.database.CursorWindow.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
