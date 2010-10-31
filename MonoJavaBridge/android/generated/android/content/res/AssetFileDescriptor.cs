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
			private static global::MonoJavaBridge.MethodId _m0;
			public override void mark(int arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "mark", "(I)V", ref global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public override void reset()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "reset", "()V", ref global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._m1);
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public override int read(byte[] arg0, int arg1, int arg2)
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "read", "([BII)I", ref global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public override int read(byte[] arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "read", "([B)I", ref global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public override int read()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "read", "()I", ref global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._m4);
			}
			private static global::MonoJavaBridge.MethodId _m5;
			public override long skip(long arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "skip", "(J)J", ref global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m6;
			public override int available()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "available", "()I", ref global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._m6);
			}
			private static global::MonoJavaBridge.MethodId _m7;
			public override bool markSupported()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "markSupported", "()Z", ref global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._m7);
			}
			private static global::MonoJavaBridge.MethodId _m8;
			public AutoCloseInputStream(android.content.res.AssetFileDescriptor arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._m8.native == global::System.IntPtr.Zero)
					global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._m8 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "<init>", "(Landroid/content/res/AssetFileDescriptor;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static AutoCloseInputStream()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/res/AssetFileDescriptor$AutoCloseInputStream"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class AutoCloseOutputStream : android.os.ParcelFileDescriptor.AutoCloseOutputStream
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected AutoCloseOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public override void write(byte[] arg0, int arg1, int arg2)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, "write", "([BII)V", ref global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public override void write(byte[] arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, "write", "([B)V", ref global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public override void write(int arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, "write", "(I)V", ref global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public AutoCloseOutputStream(android.content.res.AssetFileDescriptor arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._m3.native == global::System.IntPtr.Zero)
					global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._m3 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, "<init>", "(Landroid/content/res/AssetFileDescriptor;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static AutoCloseOutputStream()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/res/AssetFileDescriptor$AutoCloseOutputStream"));
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.AssetFileDescriptor.staticClass, "toString", "()Ljava/lang/String;", ref global::android.content.res.AssetFileDescriptor._m0) as java.lang.String;
		}
		public new long Length
		{
			get
			{
				return getLength();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual long getLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.content.res.AssetFileDescriptor.staticClass, "getLength", "()J", ref global::android.content.res.AssetFileDescriptor._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.AssetFileDescriptor.staticClass, "close", "()V", ref global::android.content.res.AssetFileDescriptor._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.AssetFileDescriptor.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.content.res.AssetFileDescriptor._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.AssetFileDescriptor.staticClass, "describeContents", "()I", ref global::android.content.res.AssetFileDescriptor._m4);
		}
		public new global::java.io.FileDescriptor FileDescriptor
		{
			get
			{
				return getFileDescriptor();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.io.FileDescriptor getFileDescriptor()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.io.FileDescriptor>(this, global::android.content.res.AssetFileDescriptor.staticClass, "getFileDescriptor", "()Ljava/io/FileDescriptor;", ref global::android.content.res.AssetFileDescriptor._m5) as java.io.FileDescriptor;
		}
		public new long StartOffset
		{
			get
			{
				return getStartOffset();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual long getStartOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.content.res.AssetFileDescriptor.staticClass, "getStartOffset", "()J", ref global::android.content.res.AssetFileDescriptor._m6);
		}
		public new global::android.os.ParcelFileDescriptor ParcelFileDescriptor
		{
			get
			{
				return getParcelFileDescriptor();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::android.os.ParcelFileDescriptor getParcelFileDescriptor()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.AssetFileDescriptor.staticClass, "getParcelFileDescriptor", "()Landroid/os/ParcelFileDescriptor;", ref global::android.content.res.AssetFileDescriptor._m7) as android.os.ParcelFileDescriptor;
		}
		public new long DeclaredLength
		{
			get
			{
				return getDeclaredLength();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual long getDeclaredLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.content.res.AssetFileDescriptor.staticClass, "getDeclaredLength", "()J", ref global::android.content.res.AssetFileDescriptor._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::java.io.FileInputStream createInputStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.AssetFileDescriptor.staticClass, "createInputStream", "()Ljava/io/FileInputStream;", ref global::android.content.res.AssetFileDescriptor._m9) as java.io.FileInputStream;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::java.io.FileOutputStream createOutputStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.AssetFileDescriptor.staticClass, "createOutputStream", "()Ljava/io/FileOutputStream;", ref global::android.content.res.AssetFileDescriptor._m10) as java.io.FileOutputStream;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public AssetFileDescriptor(android.os.ParcelFileDescriptor arg0, long arg1, long arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.AssetFileDescriptor._m11.native == global::System.IntPtr.Zero)
				global::android.content.res.AssetFileDescriptor._m11 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.staticClass, "<init>", "(Landroid/os/ParcelFileDescriptor;JJ)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		public static long UNKNOWN_LENGTH
		{
			get
			{
				return -1L;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2130;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.res.AssetFileDescriptor.staticClass, _CREATOR2130)) as android.os.Parcelable_Creator;
			}
		}
		static AssetFileDescriptor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.res.AssetFileDescriptor.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/res/AssetFileDescriptor"));
			global::android.content.res.AssetFileDescriptor._CREATOR2130 = @__env.GetStaticFieldIDNoThrow(global::android.content.res.AssetFileDescriptor.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
