namespace java.nio.channels 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class Selector : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Selector() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.nio.channels.Selector), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected Selector(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _provider12263; 
		public abstract java.nio.channels.spi.SelectorProvider provider(); 
		internal static global::net.sf.jni4net.jni.MethodId _keys12264; 
		public abstract java.util.Set keys(); 
		internal static global::net.sf.jni4net.jni.MethodId _close12265; 
		public abstract void close(); 
		internal static global::net.sf.jni4net.jni.MethodId _open12266; 
		public static java.nio.channels.Selector open() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.Selector>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.channels.Selector.staticClass, _open12266)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isOpen12267; 
		public abstract bool isOpen(); 
		internal static global::net.sf.jni4net.jni.MethodId _select12268; 
		public abstract int select(long arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _select12269; 
		public abstract int select(); 
		internal static global::net.sf.jni4net.jni.MethodId _selectedKeys12270; 
		public abstract java.util.Set selectedKeys(); 
		internal static global::net.sf.jni4net.jni.MethodId _selectNow12271; 
		public abstract int selectNow(); 
		internal static global::net.sf.jni4net.jni.MethodId _wakeup12272; 
		public abstract java.nio.channels.Selector wakeup(); 
		internal static global::net.sf.jni4net.jni.MethodId _Selector12273; 
		protected Selector()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.nio.channels.Selector.staticClass, _Selector12273, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.nio.channels.Selector.staticClass = @__class; 
			global::java.nio.channels.Selector._provider12263 = @__env.GetMethodID(global::java.nio.channels.Selector.staticClass, "provider", "()Ljava/nio/channels/spi/SelectorProvider;"); 
			global::java.nio.channels.Selector._keys12264 = @__env.GetMethodID(global::java.nio.channels.Selector.staticClass, "keys", "()Ljava/util/Set;"); 
			global::java.nio.channels.Selector._close12265 = @__env.GetMethodID(global::java.nio.channels.Selector.staticClass, "close", "()V"); 
			global::java.nio.channels.Selector._open12266 = @__env.GetStaticMethodID(global::java.nio.channels.Selector.staticClass, "open", "()Ljava/nio/channels/Selector;"); 
			global::java.nio.channels.Selector._isOpen12267 = @__env.GetMethodID(global::java.nio.channels.Selector.staticClass, "isOpen", "()Z"); 
			global::java.nio.channels.Selector._select12268 = @__env.GetMethodID(global::java.nio.channels.Selector.staticClass, "select", "(J)I"); 
			global::java.nio.channels.Selector._select12269 = @__env.GetMethodID(global::java.nio.channels.Selector.staticClass, "select", "()I"); 
			global::java.nio.channels.Selector._selectedKeys12270 = @__env.GetMethodID(global::java.nio.channels.Selector.staticClass, "selectedKeys", "()Ljava/util/Set;"); 
			global::java.nio.channels.Selector._selectNow12271 = @__env.GetMethodID(global::java.nio.channels.Selector.staticClass, "selectNow", "()I"); 
			global::java.nio.channels.Selector._wakeup12272 = @__env.GetMethodID(global::java.nio.channels.Selector.staticClass, "wakeup", "()Ljava/nio/channels/Selector;"); 
			global::java.nio.channels.Selector._Selector12273 = @__env.GetMethodID(global::java.nio.channels.Selector.staticClass, "<init>", "()V"); 
		} 
	} 
} 
