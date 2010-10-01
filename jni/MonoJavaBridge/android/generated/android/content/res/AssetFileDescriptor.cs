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
			internal static global::net.sf.jni4net.jni.MethodId _mark1867;
			public override void mark(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._mark1867, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._mark1867, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _reset1868;
			public override void reset() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._reset1868);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._reset1868);
			}
			internal static global::net.sf.jni4net.jni.MethodId _read1869;
			public override int read(byte[] arg0, int arg1, int arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read1869, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read1869, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			}
			internal static global::net.sf.jni4net.jni.MethodId _read1870;
			public override int read(byte[] arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read1870, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read1870, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _read1871;
			public override int read() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read1871);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read1871);
			}
			internal static global::net.sf.jni4net.jni.MethodId _skip1872;
			public override long skip(long arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._skip1872, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					return @__env.CallNonVirtualLongMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._skip1872, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _available1873;
			public override int available() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._available1873);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._available1873);
			}
			internal static global::net.sf.jni4net.jni.MethodId _markSupported1874;
			public override bool markSupported() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._markSupported1874);
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._markSupported1874);
			}
			internal static global::net.sf.jni4net.jni.MethodId _AutoCloseInputStream1875;
			public AutoCloseInputStream(android.content.res.AssetFileDescriptor arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._AutoCloseInputStream1875, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass = @__class;
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._mark1867 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "mark", "(I)V");
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._reset1868 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "reset", "()V");
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read1869 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "read", "([BII)I");
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read1870 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "read", "([B)I");
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read1871 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "read", "()I");
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._skip1872 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "skip", "(J)J");
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._available1873 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "available", "()I");
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._markSupported1874 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "markSupported", "()Z");
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._AutoCloseInputStream1875 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "<init>", "(Landroid/content/res/AssetFileDescriptor;)V");
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
			internal static global::net.sf.jni4net.jni.MethodId _write1876;
			public override void write(byte[] arg0, int arg1, int arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write1876, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write1876, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			}
			internal static global::net.sf.jni4net.jni.MethodId _write1877;
			public override void write(byte[] arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write1877, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write1877, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _write1878;
			public override void write(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write1878, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write1878, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _AutoCloseOutputStream1879;
			public AutoCloseOutputStream(android.content.res.AssetFileDescriptor arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._AutoCloseOutputStream1879, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass = @__class;
				global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write1876 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, "write", "([BII)V");
				global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write1877 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, "write", "([B)V");
				global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write1878 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, "write", "(I)V");
				global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._AutoCloseOutputStream1879 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, "<init>", "(Landroid/content/res/AssetFileDescriptor;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString1880;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.AssetFileDescriptor._toString1880));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._toString1880));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLength1881;
		public virtual long getLength() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.content.res.AssetFileDescriptor._getLength1881);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._getLength1881);
		}
		internal static global::net.sf.jni4net.jni.MethodId _close1882;
		public virtual void close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.res.AssetFileDescriptor._close1882);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._close1882);
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1883;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.res.AssetFileDescriptor._writeToParcel1883, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._writeToParcel1883, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1884;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.res.AssetFileDescriptor._describeContents1884);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._describeContents1884);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStartOffset1885;
		public virtual long getStartOffset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.content.res.AssetFileDescriptor._getStartOffset1885);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._getStartOffset1885);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFileDescriptor1886;
		public virtual global::java.io.FileDescriptor getFileDescriptor() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.AssetFileDescriptor._getFileDescriptor1886));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._getFileDescriptor1886));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getParcelFileDescriptor1887;
		public virtual global::android.os.ParcelFileDescriptor getParcelFileDescriptor() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.ParcelFileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.AssetFileDescriptor._getParcelFileDescriptor1887));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.ParcelFileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._getParcelFileDescriptor1887));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDeclaredLength1888;
		public virtual long getDeclaredLength() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.content.res.AssetFileDescriptor._getDeclaredLength1888);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._getDeclaredLength1888);
		}
		internal static global::net.sf.jni4net.jni.MethodId _createInputStream1889;
		public virtual global::java.io.FileInputStream createInputStream() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileInputStream>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.AssetFileDescriptor._createInputStream1889));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileInputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._createInputStream1889));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createOutputStream1890;
		public virtual global::java.io.FileOutputStream createOutputStream() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileOutputStream>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.res.AssetFileDescriptor._createOutputStream1890));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileOutputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._createOutputStream1890));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AssetFileDescriptor1891;
		public AssetFileDescriptor(android.os.ParcelFileDescriptor arg0, long arg1, long arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.res.AssetFileDescriptor.staticClass, global::android.content.res.AssetFileDescriptor._AssetFileDescriptor1891, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		public static long UNKNOWN_LENGTH
		{
			get
			{
				return -1L;
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1892;
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
			global::android.content.res.AssetFileDescriptor._toString1880 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.res.AssetFileDescriptor._getLength1881 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.staticClass, "getLength", "()J");
			global::android.content.res.AssetFileDescriptor._close1882 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.staticClass, "close", "()V");
			global::android.content.res.AssetFileDescriptor._writeToParcel1883 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.res.AssetFileDescriptor._describeContents1884 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.staticClass, "describeContents", "()I");
			global::android.content.res.AssetFileDescriptor._getStartOffset1885 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.staticClass, "getStartOffset", "()J");
			global::android.content.res.AssetFileDescriptor._getFileDescriptor1886 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.staticClass, "getFileDescriptor", "()Ljava/io/FileDescriptor;");
			global::android.content.res.AssetFileDescriptor._getParcelFileDescriptor1887 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.staticClass, "getParcelFileDescriptor", "()Landroid/os/ParcelFileDescriptor;");
			global::android.content.res.AssetFileDescriptor._getDeclaredLength1888 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.staticClass, "getDeclaredLength", "()J");
			global::android.content.res.AssetFileDescriptor._createInputStream1889 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.staticClass, "createInputStream", "()Ljava/io/FileInputStream;");
			global::android.content.res.AssetFileDescriptor._createOutputStream1890 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.staticClass, "createOutputStream", "()Ljava/io/FileOutputStream;");
			global::android.content.res.AssetFileDescriptor._AssetFileDescriptor1891 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.staticClass, "<init>", "(Landroid/os/ParcelFileDescriptor;JJ)V");
		}
	}
}
