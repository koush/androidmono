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
			internal static global::MonoJavaBridge.MethodId _mark2199;
			public override void mark(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._mark2199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._mark2199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _reset2200;
			public override void reset() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._reset2200);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._reset2200);
			}
			internal static global::MonoJavaBridge.MethodId _read2201;
			public override int read(byte[] arg0, int arg1, int arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read2201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read2201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _read2202;
			public override int read(byte[] arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read2202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read2202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _read2203;
			public override int read() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read2203);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read2203);
			}
			internal static global::MonoJavaBridge.MethodId _skip2204;
			public override long skip(long arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._skip2204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._skip2204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _available2205;
			public override int available() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._available2205);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._available2205);
			}
			internal static global::MonoJavaBridge.MethodId _markSupported2206;
			public override bool markSupported() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._markSupported2206);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._markSupported2206);
			}
			internal static global::MonoJavaBridge.MethodId _AutoCloseInputStream2207;
			public AutoCloseInputStream(android.content.res.AssetFileDescriptor arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._AutoCloseInputStream2207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/res/AssetFileDescriptor$AutoCloseInputStream"));
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._mark2199 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "mark", "(I)V");
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._reset2200 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "reset", "()V");
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read2201 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "read", "([BII)I");
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read2202 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "read", "([B)I");
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read2203 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "read", "()I");
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._skip2204 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "skip", "(J)J");
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._available2205 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "available", "()I");
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._markSupported2206 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "markSupported", "()Z");
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._AutoCloseInputStream2207 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "<init>", "(Landroid/content/res/AssetFileDescriptor;)V");
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
			internal static global::MonoJavaBridge.MethodId _write2208;
			public override void write(byte[] arg0, int arg1, int arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write2208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write2208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _write2209;
			public override void write(byte[] arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write2209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write2209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _write2210;
			public override void write(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write2210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write2210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _AutoCloseOutputStream2211;
			public AutoCloseOutputStream(android.content.res.AssetFileDescriptor arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._AutoCloseOutputStream2211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/res/AssetFileDescriptor$AutoCloseOutputStream"));
				global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write2208 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, "write", "([BII)V");
				global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write2209 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, "write", "([B)V");
				global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write2210 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, "write", "(I)V");
				global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._AutoCloseOutputStream2211 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, "<init>", "(Landroid/content/res/AssetFileDescriptor;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString2212;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor._toString2212)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._toString2212)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getLength2213;
		public virtual long getLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor._getLength2213);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._getLength2213);
		}
		internal static global::MonoJavaBridge.MethodId _close2214;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor._close2214);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._close2214);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel2215;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor._writeToParcel2215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._writeToParcel2215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents2216;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor._describeContents2216);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._describeContents2216);
		}
		internal static global::MonoJavaBridge.MethodId _getFileDescriptor2217;
		public virtual global::java.io.FileDescriptor getFileDescriptor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor._getFileDescriptor2217)) as java.io.FileDescriptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._getFileDescriptor2217)) as java.io.FileDescriptor;
		}
		internal static global::MonoJavaBridge.MethodId _getStartOffset2218;
		public virtual long getStartOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor._getStartOffset2218);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._getStartOffset2218);
		}
		internal static global::MonoJavaBridge.MethodId _getParcelFileDescriptor2219;
		public virtual global::android.os.ParcelFileDescriptor getParcelFileDescriptor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor._getParcelFileDescriptor2219)) as android.os.ParcelFileDescriptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._getParcelFileDescriptor2219)) as android.os.ParcelFileDescriptor;
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredLength2220;
		public virtual long getDeclaredLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor._getDeclaredLength2220);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._getDeclaredLength2220);
		}
		internal static global::MonoJavaBridge.MethodId _createInputStream2221;
		public virtual global::java.io.FileInputStream createInputStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor._createInputStream2221)) as java.io.FileInputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._createInputStream2221)) as java.io.FileInputStream;
		}
		internal static global::MonoJavaBridge.MethodId _createOutputStream2222;
		public virtual global::java.io.FileOutputStream createOutputStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor._createOutputStream2222)) as java.io.FileOutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._createOutputStream2222)) as java.io.FileOutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _AssetFileDescriptor2223;
		public AssetFileDescriptor(android.os.ParcelFileDescriptor arg0, long arg1, long arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._AssetFileDescriptor2223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		public static long UNKNOWN_LENGTH
		{
			get
			{
				return -1L;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2224;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.res.AssetFileDescriptor.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/res/AssetFileDescriptor"));
			global::android.content.res.AssetFileDescriptor._toString2212 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.res.AssetFileDescriptor._getLength2213 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.staticClass, "getLength", "()J");
			global::android.content.res.AssetFileDescriptor._close2214 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.staticClass, "close", "()V");
			global::android.content.res.AssetFileDescriptor._writeToParcel2215 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.res.AssetFileDescriptor._describeContents2216 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.staticClass, "describeContents", "()I");
			global::android.content.res.AssetFileDescriptor._getFileDescriptor2217 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.staticClass, "getFileDescriptor", "()Ljava/io/FileDescriptor;");
			global::android.content.res.AssetFileDescriptor._getStartOffset2218 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.staticClass, "getStartOffset", "()J");
			global::android.content.res.AssetFileDescriptor._getParcelFileDescriptor2219 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.staticClass, "getParcelFileDescriptor", "()Landroid/os/ParcelFileDescriptor;");
			global::android.content.res.AssetFileDescriptor._getDeclaredLength2220 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.staticClass, "getDeclaredLength", "()J");
			global::android.content.res.AssetFileDescriptor._createInputStream2221 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.staticClass, "createInputStream", "()Ljava/io/FileInputStream;");
			global::android.content.res.AssetFileDescriptor._createOutputStream2222 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.staticClass, "createOutputStream", "()Ljava/io/FileOutputStream;");
			global::android.content.res.AssetFileDescriptor._AssetFileDescriptor2223 = @__env.GetMethodIDNoThrow(global::android.content.res.AssetFileDescriptor.staticClass, "<init>", "(Landroid/os/ParcelFileDescriptor;JJ)V");
		}
	}
}
