namespace android.content.res 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class AssetFileDescriptor : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static AssetFileDescriptor() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.res.AssetFileDescriptor), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.res.AssetFileDescriptor.AutoCloseInputStream), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _mark1822; 
			public override void mark(int arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.res.AssetFileDescriptor.AutoCloseInputStream)) 
					@__env.CallVoidMethod(this, _mark1822, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, _mark1822, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _reset1823; 
			public override void reset() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.res.AssetFileDescriptor.AutoCloseInputStream)) 
					@__env.CallVoidMethod(this, _reset1823); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, _reset1823); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _read1824; 
			public override int read(byte[] arg0, int arg1, int arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.res.AssetFileDescriptor.AutoCloseInputStream)) 
					return @__env.CallIntMethod(this, _read1824, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, _read1824, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _read1825; 
			public override int read(byte[] arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.res.AssetFileDescriptor.AutoCloseInputStream)) 
					return @__env.CallIntMethod(this, _read1825, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, _read1825, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _read1826; 
			public override int read() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.res.AssetFileDescriptor.AutoCloseInputStream)) 
					return @__env.CallIntMethod(this, _read1826); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, _read1826); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _skip1827; 
			public override long skip(long arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.res.AssetFileDescriptor.AutoCloseInputStream)) 
					return @__env.CallLongMethod(this, _skip1827, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					return @__env.CallNonVirtualLongMethod(this, android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, _skip1827, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _available1828; 
			public override int available() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.res.AssetFileDescriptor.AutoCloseInputStream)) 
					return @__env.CallIntMethod(this, _available1828); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, _available1828); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _markSupported1829; 
			public override bool markSupported() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.res.AssetFileDescriptor.AutoCloseInputStream)) 
					return @__env.CallBooleanMethod(this, _markSupported1829); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, _markSupported1829); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _AutoCloseInputStream1830; 
			public AutoCloseInputStream(android.content.res.AssetFileDescriptor arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, _AutoCloseInputStream1830, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass = @__class; 
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._mark1822 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "mark", "(I)V"); 
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._reset1823 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "reset", "()V"); 
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read1824 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "read", "([BII)I"); 
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read1825 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "read", "([B)I"); 
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._read1826 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "read", "()I"); 
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._skip1827 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "skip", "(J)J"); 
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._available1828 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "available", "()I"); 
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._markSupported1829 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "markSupported", "()Z"); 
				global::android.content.res.AssetFileDescriptor.AutoCloseInputStream._AutoCloseInputStream1830 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.AutoCloseInputStream.staticClass, "<init>", "(Landroid/content/res/AssetFileDescriptor;)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class AutoCloseOutputStream : android.os.ParcelFileDescriptor.AutoCloseOutputStream
		{ 
			internal new static global::java.lang.Class staticClass; 
			static AutoCloseOutputStream() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.res.AssetFileDescriptor.AutoCloseOutputStream), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _write1831; 
			public override void write(byte[] arg0, int arg1, int arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.res.AssetFileDescriptor.AutoCloseOutputStream)) 
					@__env.CallVoidMethod(this, _write1831, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, _write1831, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _write1832; 
			public override void write(byte[] arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.res.AssetFileDescriptor.AutoCloseOutputStream)) 
					@__env.CallVoidMethod(this, _write1832, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, _write1832, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _write1833; 
			public override void write(int arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.res.AssetFileDescriptor.AutoCloseOutputStream)) 
					@__env.CallVoidMethod(this, _write1833, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, _write1833, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _AutoCloseOutputStream1834; 
			public AutoCloseOutputStream(android.content.res.AssetFileDescriptor arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, _AutoCloseOutputStream1834, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass = @__class; 
				global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write1831 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, "write", "([BII)V"); 
				global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write1832 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, "write", "([B)V"); 
				global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._write1833 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, "write", "(I)V"); 
				global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream._AutoCloseOutputStream1834 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.AutoCloseOutputStream.staticClass, "<init>", "(Landroid/content/res/AssetFileDescriptor;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLength1835; 
		public virtual long getLength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.AssetFileDescriptor)) 
				return @__env.CallLongMethod(this, _getLength1835); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.content.res.AssetFileDescriptor.staticClass, _getLength1835); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString1836; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.AssetFileDescriptor)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString1836)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.AssetFileDescriptor.staticClass, _toString1836)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close1837; 
		public virtual void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.AssetFileDescriptor)) 
				@__env.CallVoidMethod(this, _close1837); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.res.AssetFileDescriptor.staticClass, _close1837); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1838; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.AssetFileDescriptor)) 
				@__env.CallVoidMethod(this, _writeToParcel1838, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.res.AssetFileDescriptor.staticClass, _writeToParcel1838, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1839; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.AssetFileDescriptor)) 
				return @__env.CallIntMethod(this, _describeContents1839); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.res.AssetFileDescriptor.staticClass, _describeContents1839); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStartOffset1840; 
		public virtual long getStartOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.AssetFileDescriptor)) 
				return @__env.CallLongMethod(this, _getStartOffset1840); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.content.res.AssetFileDescriptor.staticClass, _getStartOffset1840); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFileDescriptor1841; 
		public virtual java.io.FileDescriptor getFileDescriptor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.AssetFileDescriptor)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, _getFileDescriptor1841)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.AssetFileDescriptor.staticClass, _getFileDescriptor1841)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getParcelFileDescriptor1842; 
		public virtual android.os.ParcelFileDescriptor getParcelFileDescriptor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.AssetFileDescriptor)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.ParcelFileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, _getParcelFileDescriptor1842)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.ParcelFileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.AssetFileDescriptor.staticClass, _getParcelFileDescriptor1842)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDeclaredLength1843; 
		public virtual long getDeclaredLength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.AssetFileDescriptor)) 
				return @__env.CallLongMethod(this, _getDeclaredLength1843); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.content.res.AssetFileDescriptor.staticClass, _getDeclaredLength1843); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createInputStream1844; 
		public virtual java.io.FileInputStream createInputStream() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.AssetFileDescriptor)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileInputStream>(@__env, @__env.CallObjectMethodPtr(this, _createInputStream1844)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileInputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.AssetFileDescriptor.staticClass, _createInputStream1844)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createOutputStream1845; 
		public virtual java.io.FileOutputStream createOutputStream() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.res.AssetFileDescriptor)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileOutputStream>(@__env, @__env.CallObjectMethodPtr(this, _createOutputStream1845)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileOutputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.res.AssetFileDescriptor.staticClass, _createOutputStream1845)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AssetFileDescriptor1846; 
		public AssetFileDescriptor(android.os.ParcelFileDescriptor arg0, long arg1, long arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.res.AssetFileDescriptor.staticClass, _AssetFileDescriptor1846, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		public static long UNKNOWN_LENGTH
		{ 
			get 
			{ 
				return -1L; 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1847; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.res.AssetFileDescriptor.staticClass = @__class; 
			global::android.content.res.AssetFileDescriptor._getLength1835 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.staticClass, "getLength", "()J"); 
			global::android.content.res.AssetFileDescriptor._toString1836 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.content.res.AssetFileDescriptor._close1837 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.staticClass, "close", "()V"); 
			global::android.content.res.AssetFileDescriptor._writeToParcel1838 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.content.res.AssetFileDescriptor._describeContents1839 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.staticClass, "describeContents", "()I"); 
			global::android.content.res.AssetFileDescriptor._getStartOffset1840 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.staticClass, "getStartOffset", "()J"); 
			global::android.content.res.AssetFileDescriptor._getFileDescriptor1841 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.staticClass, "getFileDescriptor", "()Ljava/io/FileDescriptor;"); 
			global::android.content.res.AssetFileDescriptor._getParcelFileDescriptor1842 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.staticClass, "getParcelFileDescriptor", "()Landroid/os/ParcelFileDescriptor;"); 
			global::android.content.res.AssetFileDescriptor._getDeclaredLength1843 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.staticClass, "getDeclaredLength", "()J"); 
			global::android.content.res.AssetFileDescriptor._createInputStream1844 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.staticClass, "createInputStream", "()Ljava/io/FileInputStream;"); 
			global::android.content.res.AssetFileDescriptor._createOutputStream1845 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.staticClass, "createOutputStream", "()Ljava/io/FileOutputStream;"); 
			global::android.content.res.AssetFileDescriptor._AssetFileDescriptor1846 = @__env.GetMethodID(global::android.content.res.AssetFileDescriptor.staticClass, "<init>", "(Landroid/os/ParcelFileDescriptor;JJ)V"); 
		} 
	} 
} 
