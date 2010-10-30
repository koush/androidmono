namespace android.content.res
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AssetFileDescriptor : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AssetFileDescriptor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class AutoCloseInputStream : android.os.ParcelFileDescriptor.AutoCloseInputStream
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected AutoCloseInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _mark4065;
			public override void mark(int arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "mark", "(I)V", ref global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._mark4065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _reset4066;
			public override void reset()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "reset", "()V", ref global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._reset4066);
			}
			internal static global::MonoJavaBridge.MethodId _read4067;
			public override int read(byte[] arg0, int arg1, int arg2)
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "read", "([BII)I", ref global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read4067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _read4068;
			public override int read(byte[] arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "read", "([B)I", ref global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read4068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _read4069;
			public override int read()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "read", "()I", ref global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read4069);
			}
			internal static global::MonoJavaBridge.MethodId _skip4070;
			public override long skip(long arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "skip", "(J)J", ref global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._skip4070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _available4071;
			public override int available()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "available", "()I", ref global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._available4071);
			}
			internal static global::MonoJavaBridge.MethodId _markSupported4072;
			public override bool markSupported()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "markSupported", "()Z", ref global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._markSupported4072);
			}
			internal static global::MonoJavaBridge.MethodId _AutoCloseInputStream4073;
			public AutoCloseInputStream(android.content.res.AssetFileDescriptor arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._AutoCloseInputStream4073.native == global::System.IntPtr.Zero)
					global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._AutoCloseInputStream4073 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "<init>", "(Landroid/content/res/AssetFileDescriptor;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._AutoCloseInputStream4073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static AutoCloseInputStream()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/res/AssetFileDescriptor$AutoCloseInputStream"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class AutoCloseOutputStream : android.os.ParcelFileDescriptor.AutoCloseOutputStream
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected AutoCloseOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _write4074;
			public override void write(byte[] arg0, int arg1, int arg2)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, "write", "([BII)V", ref global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write4074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _write4075;
			public override void write(byte[] arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, "write", "([B)V", ref global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write4075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _write4076;
			public override void write(int arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, "write", "(I)V", ref global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write4076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _AutoCloseOutputStream4077;
			public AutoCloseOutputStream(android.content.res.AssetFileDescriptor arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._AutoCloseOutputStream4077.native == global::System.IntPtr.Zero)
					global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._AutoCloseOutputStream4077 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, "<init>", "(Landroid/content/res/AssetFileDescriptor;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._AutoCloseOutputStream4077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static AutoCloseOutputStream()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/res/AssetFileDescriptor$AutoCloseOutputStream"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString4078;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.AssetFileDescriptor.staticClass, "toString", "()Ljava/lang/String;", ref global::android.content.res.AssetFileDescriptor._toString4078) as java.lang.String;
		}
		public new long Length
		{
			get
			{
				return getLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLength4079;
		public virtual long getLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.content.res.AssetFileDescriptor.staticClass, "getLength", "()J", ref global::android.content.res.AssetFileDescriptor._getLength4079);
		}
		internal static global::MonoJavaBridge.MethodId _close4080;
		public virtual void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.AssetFileDescriptor.staticClass, "close", "()V", ref global::android.content.res.AssetFileDescriptor._close4080);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel4081;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.AssetFileDescriptor.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.content.res.AssetFileDescriptor._writeToParcel4081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents4082;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.AssetFileDescriptor.staticClass, "describeContents", "()I", ref global::android.content.res.AssetFileDescriptor._describeContents4082);
		}
		public new global::java.io.FileDescriptor FileDescriptor
		{
			get
			{
				return getFileDescriptor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFileDescriptor4083;
		public virtual global::java.io.FileDescriptor getFileDescriptor()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.io.FileDescriptor>(this, global::android.content.res.AssetFileDescriptor.staticClass, "getFileDescriptor", "()Ljava/io/FileDescriptor;", ref global::android.content.res.AssetFileDescriptor._getFileDescriptor4083) as java.io.FileDescriptor;
		}
		public new long StartOffset
		{
			get
			{
				return getStartOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStartOffset4084;
		public virtual long getStartOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.content.res.AssetFileDescriptor.staticClass, "getStartOffset", "()J", ref global::android.content.res.AssetFileDescriptor._getStartOffset4084);
		}
		public new global::android.os.ParcelFileDescriptor ParcelFileDescriptor
		{
			get
			{
				return getParcelFileDescriptor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParcelFileDescriptor4085;
		public virtual global::android.os.ParcelFileDescriptor getParcelFileDescriptor()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.AssetFileDescriptor.staticClass, "getParcelFileDescriptor", "()Landroid/os/ParcelFileDescriptor;", ref global::android.content.res.AssetFileDescriptor._getParcelFileDescriptor4085) as android.os.ParcelFileDescriptor;
		}
		public new long DeclaredLength
		{
			get
			{
				return getDeclaredLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredLength4086;
		public virtual long getDeclaredLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.content.res.AssetFileDescriptor.staticClass, "getDeclaredLength", "()J", ref global::android.content.res.AssetFileDescriptor._getDeclaredLength4086);
		}
		internal static global::MonoJavaBridge.MethodId _createInputStream4087;
		public virtual global::java.io.FileInputStream createInputStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.AssetFileDescriptor.staticClass, "createInputStream", "()Ljava/io/FileInputStream;", ref global::android.content.res.AssetFileDescriptor._createInputStream4087) as java.io.FileInputStream;
		}
		internal static global::MonoJavaBridge.MethodId _createOutputStream4088;
		public virtual global::java.io.FileOutputStream createOutputStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.AssetFileDescriptor.staticClass, "createOutputStream", "()Ljava/io/FileOutputStream;", ref global::android.content.res.AssetFileDescriptor._createOutputStream4088) as java.io.FileOutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _AssetFileDescriptor4089;
		public AssetFileDescriptor(android.os.ParcelFileDescriptor arg0, long arg1, long arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.AssetFileDescriptor._AssetFileDescriptor4089.native == global::System.IntPtr.Zero)
				global::android.content.res.AssetFileDescriptor._AssetFileDescriptor4089 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.staticClass, "<init>", "(Landroid/os/ParcelFileDescriptor;JJ)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._AssetFileDescriptor4089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		public static long UNKNOWN_LENGTH
		{
			get
			{
				return -1L;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR4091;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.res.AssetFileDescriptor.staticClass, _CREATOR4091)) as android.os.Parcelable_Creator;
			}
		}
		static AssetFileDescriptor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.res.AssetFileDescriptor.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/res/AssetFileDescriptor"));
			global::android.content.res.AssetFileDescriptor._CREATOR4091 = @__env.GetStaticFieldIDNoThrow(global::android.content.res.AssetFileDescriptor.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
