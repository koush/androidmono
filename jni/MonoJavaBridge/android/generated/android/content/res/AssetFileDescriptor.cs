namespace android.content.res
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AssetFileDescriptor : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AssetFileDescriptor()
		{
			InitJNI();
		}
		protected AssetFileDescriptor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class AutoCloseInputStream : android.os.ParcelFileDescriptor.AutoCloseInputStream
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static AutoCloseInputStream()
			{
				InitJNI();
			}
			protected AutoCloseInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _mark4048;
			public override void mark(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._mark4048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._mark4048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _reset4049;
			public override void reset() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._reset4049);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._reset4049);
			}
			internal static global::MonoJavaBridge.MethodId _read4050;
			public override int read(byte[] arg0, int arg1, int arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read4050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read4050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _read4051;
			public override int read(byte[] arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read4051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read4051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _read4052;
			public override int read() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read4052);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read4052);
			}
			internal static global::MonoJavaBridge.MethodId _skip4053;
			public override long skip(long arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._skip4053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._skip4053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _available4054;
			public override int available() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._available4054);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._available4054);
			}
			internal static global::MonoJavaBridge.MethodId _markSupported4055;
			public override bool markSupported() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._markSupported4055);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._markSupported4055);
			}
			internal static global::MonoJavaBridge.MethodId _AutoCloseInputStream4056;
			public AutoCloseInputStream(android.content.res.AssetFileDescriptor arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._AutoCloseInputStream4056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/res/AssetFileDescriptor$AutoCloseInputStream"));
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._mark4048 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "mark", "(I)V");
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._reset4049 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "reset", "()V");
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read4050 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "read", "([BII)I");
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read4051 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "read", "([B)I");
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read4052 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "read", "()I");
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._skip4053 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "skip", "(J)J");
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._available4054 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "available", "()I");
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._markSupported4055 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "markSupported", "()Z");
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._AutoCloseInputStream4056 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "<init>", "(Landroid/content/res/AssetFileDescriptor;)V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class AutoCloseOutputStream : android.os.ParcelFileDescriptor.AutoCloseOutputStream
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static AutoCloseOutputStream()
			{
				InitJNI();
			}
			protected AutoCloseOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _write4057;
			public override void write(byte[] arg0, int arg1, int arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write4057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write4057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _write4058;
			public override void write(byte[] arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write4058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write4058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _write4059;
			public override void write(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write4059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write4059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _AutoCloseOutputStream4060;
			public AutoCloseOutputStream(android.content.res.AssetFileDescriptor arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._AutoCloseOutputStream4060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/res/AssetFileDescriptor$AutoCloseOutputStream"));
				global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write4057 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, "write", "([BII)V");
				global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write4058 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, "write", "([B)V");
				global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write4059 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, "write", "(I)V");
				global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._AutoCloseOutputStream4060 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, "<init>", "(Landroid/content/res/AssetFileDescriptor;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString4061;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor._toString4061)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._toString4061)) as java.lang.String;
		}
		public new long Length
		{
			get
			{
				return getLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLength4062;
		public virtual long getLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor._getLength4062);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._getLength4062);
		}
		internal static global::MonoJavaBridge.MethodId _close4063;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor._close4063);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._close4063);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel4064;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor._writeToParcel4064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._writeToParcel4064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents4065;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor._describeContents4065);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._describeContents4065);
		}
		public new global::java.io.FileDescriptor FileDescriptor
		{
			get
			{
				return getFileDescriptor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFileDescriptor4066;
		public virtual global::java.io.FileDescriptor getFileDescriptor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.io.FileDescriptor>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor._getFileDescriptor4066)) as java.io.FileDescriptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.io.FileDescriptor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._getFileDescriptor4066)) as java.io.FileDescriptor;
		}
		public new long StartOffset
		{
			get
			{
				return getStartOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStartOffset4067;
		public virtual long getStartOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor._getStartOffset4067);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._getStartOffset4067);
		}
		public new global::android.os.ParcelFileDescriptor ParcelFileDescriptor
		{
			get
			{
				return getParcelFileDescriptor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParcelFileDescriptor4068;
		public virtual global::android.os.ParcelFileDescriptor getParcelFileDescriptor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor._getParcelFileDescriptor4068)) as android.os.ParcelFileDescriptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._getParcelFileDescriptor4068)) as android.os.ParcelFileDescriptor;
		}
		public new long DeclaredLength
		{
			get
			{
				return getDeclaredLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredLength4069;
		public virtual long getDeclaredLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor._getDeclaredLength4069);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._getDeclaredLength4069);
		}
		internal static global::MonoJavaBridge.MethodId _createInputStream4070;
		public virtual global::java.io.FileInputStream createInputStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor._createInputStream4070)) as java.io.FileInputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._createInputStream4070)) as java.io.FileInputStream;
		}
		internal static global::MonoJavaBridge.MethodId _createOutputStream4071;
		public virtual global::java.io.FileOutputStream createOutputStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor._createOutputStream4071)) as java.io.FileOutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._createOutputStream4071)) as java.io.FileOutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _AssetFileDescriptor4072;
		public AssetFileDescriptor(android.os.ParcelFileDescriptor arg0, long arg1, long arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._AssetFileDescriptor4072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		public static long UNKNOWN_LENGTH
		{
			get
			{
				return -1L;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR4074;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.res.AssetFileDescriptor.staticClass, _CREATOR4074)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.res.AssetFileDescriptor.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/res/AssetFileDescriptor"));
			global::android.content.res.AssetFileDescriptor._toString4061 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.res.AssetFileDescriptor._getLength4062 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.staticClass, "getLength", "()J");
			global::android.content.res.AssetFileDescriptor._close4063 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.staticClass, "close", "()V");
			global::android.content.res.AssetFileDescriptor._writeToParcel4064 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.res.AssetFileDescriptor._describeContents4065 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.staticClass, "describeContents", "()I");
			global::android.content.res.AssetFileDescriptor._getFileDescriptor4066 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.staticClass, "getFileDescriptor", "()Ljava/io/FileDescriptor;");
			global::android.content.res.AssetFileDescriptor._getStartOffset4067 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.staticClass, "getStartOffset", "()J");
			global::android.content.res.AssetFileDescriptor._getParcelFileDescriptor4068 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.staticClass, "getParcelFileDescriptor", "()Landroid/os/ParcelFileDescriptor;");
			global::android.content.res.AssetFileDescriptor._getDeclaredLength4069 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.staticClass, "getDeclaredLength", "()J");
			global::android.content.res.AssetFileDescriptor._createInputStream4070 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.staticClass, "createInputStream", "()Ljava/io/FileInputStream;");
			global::android.content.res.AssetFileDescriptor._createOutputStream4071 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.staticClass, "createOutputStream", "()Ljava/io/FileOutputStream;");
			global::android.content.res.AssetFileDescriptor._AssetFileDescriptor4072 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.staticClass, "<init>", "(Landroid/os/ParcelFileDescriptor;JJ)V");
			global::android.content.res.AssetFileDescriptor._CREATOR4074 = @__env.GetStaticFieldIDNoThrow(global::android.content.res.AssetFileDescriptor.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
