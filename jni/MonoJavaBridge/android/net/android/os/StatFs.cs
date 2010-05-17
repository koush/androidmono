namespace android.os 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class StatFs : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static StatFs() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.os.StatFs), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.os.StatFs(@__env); 
			} 
		} 
		protected StatFs(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _restat5595; 
		public virtual void restat(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.StatFs)) 
				@__env.CallVoidMethod(this, _restat5595, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.StatFs.staticClass, _restat5595, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBlockSize5596; 
		public virtual int getBlockSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.StatFs)) 
				return @__env.CallIntMethod(this, _getBlockSize5596); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.os.StatFs.staticClass, _getBlockSize5596); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBlockCount5597; 
		public virtual int getBlockCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.StatFs)) 
				return @__env.CallIntMethod(this, _getBlockCount5597); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.os.StatFs.staticClass, _getBlockCount5597); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFreeBlocks5598; 
		public virtual int getFreeBlocks() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.StatFs)) 
				return @__env.CallIntMethod(this, _getFreeBlocks5598); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.os.StatFs.staticClass, _getFreeBlocks5598); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAvailableBlocks5599; 
		public virtual int getAvailableBlocks() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.StatFs)) 
				return @__env.CallIntMethod(this, _getAvailableBlocks5599); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.os.StatFs.staticClass, _getAvailableBlocks5599); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _StatFs5600; 
		public StatFs(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.StatFs.staticClass, _StatFs5600, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.os.StatFs.staticClass = @__class; 
			global::android.os.StatFs._restat5595 = @__env.GetMethodID(global::android.os.StatFs.staticClass, "restat", "(Ljava/lang/String;)V"); 
			global::android.os.StatFs._getBlockSize5596 = @__env.GetMethodID(global::android.os.StatFs.staticClass, "getBlockSize", "()I"); 
			global::android.os.StatFs._getBlockCount5597 = @__env.GetMethodID(global::android.os.StatFs.staticClass, "getBlockCount", "()I"); 
			global::android.os.StatFs._getFreeBlocks5598 = @__env.GetMethodID(global::android.os.StatFs.staticClass, "getFreeBlocks", "()I"); 
			global::android.os.StatFs._getAvailableBlocks5599 = @__env.GetMethodID(global::android.os.StatFs.staticClass, "getAvailableBlocks", "()I"); 
			global::android.os.StatFs._StatFs5600 = @__env.GetMethodID(global::android.os.StatFs.staticClass, "<init>", "(Ljava/lang/String;)V"); 
		} 
	} 
} 
