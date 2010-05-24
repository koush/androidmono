namespace android.os 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class MemoryFile : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static MemoryFile() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.os.MemoryFile), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.os.MemoryFile(@__env); 
			} 
		} 
		protected MemoryFile(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _length5639; 
		public virtual int length() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.MemoryFile)) 
				return @__env.CallIntMethod(this, _length5639); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.os.MemoryFile.staticClass, _length5639); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close5640; 
		public virtual void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.MemoryFile)) 
				@__env.CallVoidMethod(this, _close5640); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.MemoryFile.staticClass, _close5640); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readBytes5641; 
		public virtual int readBytes(byte[] arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.MemoryFile)) 
				return @__env.CallIntMethod(this, _readBytes5641, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.os.MemoryFile.staticClass, _readBytes5641, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeBytes5642; 
		public virtual void writeBytes(byte[] arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.MemoryFile)) 
				@__env.CallVoidMethod(this, _writeBytes5642, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.MemoryFile.staticClass, _writeBytes5642, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInputStream5643; 
		public virtual java.io.InputStream getInputStream() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.MemoryFile)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallObjectMethodPtr(this, _getInputStream5643)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.MemoryFile.staticClass, _getInputStream5643)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOutputStream5644; 
		public virtual java.io.OutputStream getOutputStream() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.MemoryFile)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.OutputStream>(@__env, @__env.CallObjectMethodPtr(this, _getOutputStream5644)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.OutputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.MemoryFile.staticClass, _getOutputStream5644)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isPurgingAllowed5645; 
		public virtual bool isPurgingAllowed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.MemoryFile)) 
				return @__env.CallBooleanMethod(this, _isPurgingAllowed5645); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.os.MemoryFile.staticClass, _isPurgingAllowed5645); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _allowPurging5646; 
		public virtual bool allowPurging(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.MemoryFile)) 
				return @__env.CallBooleanMethod(this, _allowPurging5646, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.os.MemoryFile.staticClass, _allowPurging5646, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _MemoryFile5647; 
		public MemoryFile(java.lang.String arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.MemoryFile.staticClass, _MemoryFile5647, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.os.MemoryFile.staticClass = @__class; 
			global::android.os.MemoryFile._length5639 = @__env.GetMethodID(global::android.os.MemoryFile.staticClass, "length", "()I"); 
			global::android.os.MemoryFile._close5640 = @__env.GetMethodID(global::android.os.MemoryFile.staticClass, "close", "()V"); 
			global::android.os.MemoryFile._readBytes5641 = @__env.GetMethodID(global::android.os.MemoryFile.staticClass, "readBytes", "([BIII)I"); 
			global::android.os.MemoryFile._writeBytes5642 = @__env.GetMethodID(global::android.os.MemoryFile.staticClass, "writeBytes", "([BIII)V"); 
			global::android.os.MemoryFile._getInputStream5643 = @__env.GetMethodID(global::android.os.MemoryFile.staticClass, "getInputStream", "()Ljava/io/InputStream;"); 
			global::android.os.MemoryFile._getOutputStream5644 = @__env.GetMethodID(global::android.os.MemoryFile.staticClass, "getOutputStream", "()Ljava/io/OutputStream;"); 
			global::android.os.MemoryFile._isPurgingAllowed5645 = @__env.GetMethodID(global::android.os.MemoryFile.staticClass, "isPurgingAllowed", "()Z"); 
			global::android.os.MemoryFile._allowPurging5646 = @__env.GetMethodID(global::android.os.MemoryFile.staticClass, "allowPurging", "(Z)Z"); 
			global::android.os.MemoryFile._MemoryFile5647 = @__env.GetMethodID(global::android.os.MemoryFile.staticClass, "<init>", "(Ljava/lang/String;I)V"); 
		} 
	} 
} 
