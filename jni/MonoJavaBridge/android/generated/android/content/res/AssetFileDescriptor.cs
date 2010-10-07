namespace android.content.res
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class AssetFileDescriptor : java.lang.Object, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static AssetFileDescriptor()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.res.AssetFileDescriptor), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.content.res.AssetFileDescriptor(@__env);
			}
		}
		protected AssetFileDescriptor(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class AutoCloseInputStream : android.os.ParcelFileDescriptor.AutoCloseInputStream
		{
			internal new static global::java.lang.Class staticClass;
			static AutoCloseInputStream()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.content.res.AssetFileDescriptor.AutoCloseInputStream(@__env);
				}
			}
			protected AutoCloseInputStream(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _mark2045;
			public override void mark(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._mark2045, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._mark2045, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _reset2046;
			public override void reset() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._reset2046);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._reset2046);
			}
			internal static global::net.sf.jni4net.jni.MethodId _read2047;
			public override int read(byte[] arg0, int arg1, int arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read2047, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read2047, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			}
			internal static global::net.sf.jni4net.jni.MethodId _read2048;
			public override int read(byte[] arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read2048, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read2048, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _read2049;
			public override int read() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read2049);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read2049);
			}
			internal static global::net.sf.jni4net.jni.MethodId _skip2050;
			public override long skip(long arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._skip2050, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					return @__env.CallNonVirtualLongMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._skip2050, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _available2051;
			public override int available() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._available2051);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._available2051);
			}
			internal static global::net.sf.jni4net.jni.MethodId _markSupported2052;
			public override bool markSupported() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._markSupported2052);
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._markSupported2052);
			}
			internal static global::net.sf.jni4net.jni.MethodId _AutoCloseInputStream2053;
			public AutoCloseInputStream(android.content.res.AssetFileDescriptor arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._AutoCloseInputStream2053, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass = @__class;
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._mark2045 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "mark", "(I)V");
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._reset2046 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "reset", "()V");
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read2047 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "read", "([BII)I");
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read2048 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "read", "([B)I");
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read2049 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "read", "()I");
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._skip2050 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "skip", "(J)J");
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._available2051 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "available", "()I");
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._markSupported2052 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "markSupported", "()Z");
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._AutoCloseInputStream2053 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "<init>", "(Landroid/content/res/AssetFileDescriptor;)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class AutoCloseOutputStream : android.os.ParcelFileDescriptor.AutoCloseOutputStream
		{
			internal new static global::java.lang.Class staticClass;
			static AutoCloseOutputStream()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream(@__env);
				}
			}
			protected AutoCloseOutputStream(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _write2054;
			public override void write(byte[] arg0, int arg1, int arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write2054, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write2054, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			}
			internal static global::net.sf.jni4net.jni.MethodId _write2055;
			public override void write(byte[] arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write2055, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write2055, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _write2056;
			public override void write(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write2056, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write2056, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _AutoCloseOutputStream2057;
			public AutoCloseOutputStream(android.content.res.AssetFileDescriptor arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._AutoCloseOutputStream2057, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass = @__class;
				global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write2054 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, "write", "([BII)V");
				global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write2055 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, "write", "([B)V");
				global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write2056 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, "write", "(I)V");
				global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._AutoCloseOutputStream2057 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, "<init>", "(Landroid/content/res/AssetFileDescriptor;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString2058;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.AssetFileDescriptor._toString2058));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._toString2058));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLength2059;
		public virtual long getLength() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.content.res.AssetFileDescriptor._getLength2059);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._getLength2059);
		}
		internal static global::net.sf.jni4net.jni.MethodId _close2060;
		public virtual void close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.res.AssetFileDescriptor._close2060);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._close2060);
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel2061;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.res.AssetFileDescriptor._writeToParcel2061, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._writeToParcel2061, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents2062;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.AssetFileDescriptor._describeContents2062);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._describeContents2062);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFileDescriptor2063;
		public virtual global::java.io.FileDescriptor getFileDescriptor() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.AssetFileDescriptor._getFileDescriptor2063));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._getFileDescriptor2063));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStartOffset2064;
		public virtual long getStartOffset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.content.res.AssetFileDescriptor._getStartOffset2064);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._getStartOffset2064);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getParcelFileDescriptor2065;
		public virtual global::android.os.ParcelFileDescriptor getParcelFileDescriptor() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.ParcelFileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.AssetFileDescriptor._getParcelFileDescriptor2065));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.ParcelFileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._getParcelFileDescriptor2065));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDeclaredLength2066;
		public virtual long getDeclaredLength() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.content.res.AssetFileDescriptor._getDeclaredLength2066);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._getDeclaredLength2066);
		}
		internal static global::net.sf.jni4net.jni.MethodId _createInputStream2067;
		public virtual global::java.io.FileInputStream createInputStream() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileInputStream>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.AssetFileDescriptor._createInputStream2067));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileInputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._createInputStream2067));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createOutputStream2068;
		public virtual global::java.io.FileOutputStream createOutputStream() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileOutputStream>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.AssetFileDescriptor._createOutputStream2068));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileOutputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._createOutputStream2068));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AssetFileDescriptor2069;
		public AssetFileDescriptor(android.os.ParcelFileDescriptor arg0, long arg1, long arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._AssetFileDescriptor2069, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		public static long UNKNOWN_LENGTH
		{
			get
			{
				return -1L;
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR2070;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.res.AssetFileDescriptor.staticClass = @__class;
			global::android.content.res.AssetFileDescriptor._toString2058 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.res.AssetFileDescriptor._getLength2059 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.staticClass, "getLength", "()J");
			global::android.content.res.AssetFileDescriptor._close2060 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.staticClass, "close", "()V");
			global::android.content.res.AssetFileDescriptor._writeToParcel2061 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.res.AssetFileDescriptor._describeContents2062 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.staticClass, "describeContents", "()I");
			global::android.content.res.AssetFileDescriptor._getFileDescriptor2063 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.staticClass, "getFileDescriptor", "()Ljava/io/FileDescriptor;");
			global::android.content.res.AssetFileDescriptor._getStartOffset2064 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.staticClass, "getStartOffset", "()J");
			global::android.content.res.AssetFileDescriptor._getParcelFileDescriptor2065 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.staticClass, "getParcelFileDescriptor", "()Landroid/os/ParcelFileDescriptor;");
			global::android.content.res.AssetFileDescriptor._getDeclaredLength2066 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.staticClass, "getDeclaredLength", "()J");
			global::android.content.res.AssetFileDescriptor._createInputStream2067 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.staticClass, "createInputStream", "()Ljava/io/FileInputStream;");
			global::android.content.res.AssetFileDescriptor._createOutputStream2068 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.staticClass, "createOutputStream", "()Ljava/io/FileOutputStream;");
			global::android.content.res.AssetFileDescriptor._AssetFileDescriptor2069 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.staticClass, "<init>", "(Landroid/os/ParcelFileDescriptor;JJ)V");
		}
	}
}
