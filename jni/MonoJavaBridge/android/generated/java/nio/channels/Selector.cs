namespace java.nio.channels
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class Selector : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Selector()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.nio.channels.Selector), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected Selector(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _provider12992;
		public abstract global::java.nio.channels.spi.SelectorProvider provider();
		internal static global::net.sf.jni4net.jni.MethodId _keys12993;
		public abstract global::java.util.Set keys();
		internal static global::net.sf.jni4net.jni.MethodId _close12994;
		public abstract void close();
		internal static global::net.sf.jni4net.jni.MethodId _open12995;
		public static global::java.nio.channels.Selector open() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.Selector>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.channels.Selector.staticClass, global::java.nio.channels.Selector._open12995));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isOpen12996;
		public abstract bool isOpen();
		internal static global::net.sf.jni4net.jni.MethodId _select12997;
		public abstract int select(long arg0);
		internal static global::net.sf.jni4net.jni.MethodId _select12998;
		public abstract int select();
		internal static global::net.sf.jni4net.jni.MethodId _selectedKeys12999;
		public abstract global::java.util.Set selectedKeys();
		internal static global::net.sf.jni4net.jni.MethodId _selectNow13000;
		public abstract int selectNow();
		internal static global::net.sf.jni4net.jni.MethodId _wakeup13001;
		public abstract global::java.nio.channels.Selector wakeup();
		internal static global::net.sf.jni4net.jni.MethodId _Selector13002;
		protected Selector()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.nio.channels.Selector.staticClass, global::java.nio.channels.Selector._Selector13002, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.nio.channels.Selector.staticClass = @__class;
			global::java.nio.channels.Selector._provider12992 = @__env.GetMethodID(global::java.nio.channels.Selector.staticClass, "provider", "()Ljava/nio/channels/spi/SelectorProvider;");
			global::java.nio.channels.Selector._keys12993 = @__env.GetMethodID(global::java.nio.channels.Selector.staticClass, "keys", "()Ljava/util/Set;");
			global::java.nio.channels.Selector._close12994 = @__env.GetMethodID(global::java.nio.channels.Selector.staticClass, "close", "()V");
			global::java.nio.channels.Selector._open12995 = @__env.GetStaticMethodID(global::java.nio.channels.Selector.staticClass, "open", "()Ljava/nio/channels/Selector;");
			global::java.nio.channels.Selector._isOpen12996 = @__env.GetMethodID(global::java.nio.channels.Selector.staticClass, "isOpen", "()Z");
			global::java.nio.channels.Selector._select12997 = @__env.GetMethodID(global::java.nio.channels.Selector.staticClass, "select", "(J)I");
			global::java.nio.channels.Selector._select12998 = @__env.GetMethodID(global::java.nio.channels.Selector.staticClass, "select", "()I");
			global::java.nio.channels.Selector._selectedKeys12999 = @__env.GetMethodID(global::java.nio.channels.Selector.staticClass, "selectedKeys", "()Ljava/util/Set;");
			global::java.nio.channels.Selector._selectNow13000 = @__env.GetMethodID(global::java.nio.channels.Selector.staticClass, "selectNow", "()I");
			global::java.nio.channels.Selector._wakeup13001 = @__env.GetMethodID(global::java.nio.channels.Selector.staticClass, "wakeup", "()Ljava/nio/channels/Selector;");
			global::java.nio.channels.Selector._Selector13002 = @__env.GetMethodID(global::java.nio.channels.Selector.staticClass, "<init>", "()V");
		}
	}
}
