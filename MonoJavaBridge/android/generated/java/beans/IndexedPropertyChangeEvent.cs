namespace java.beans
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IndexedPropertyChangeEvent : java.beans.PropertyChangeEvent
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected IndexedPropertyChangeEvent(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new int Index
		{
			get
			{
				return getIndex();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual int getIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.beans.IndexedPropertyChangeEvent.staticClass, "getIndex", "()I", ref global::java.beans.IndexedPropertyChangeEvent._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public IndexedPropertyChangeEvent(java.lang.Object arg0, java.lang.String arg1, java.lang.Object arg2, java.lang.Object arg3, int arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.beans.IndexedPropertyChangeEvent._m1.native == global::System.IntPtr.Zero)
				global::java.beans.IndexedPropertyChangeEvent._m1 = @__env.GetMethodIDNoThrow(global::java.beans.IndexedPropertyChangeEvent.staticClass, "<init>", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.beans.IndexedPropertyChangeEvent.staticClass, global::java.beans.IndexedPropertyChangeEvent._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		static IndexedPropertyChangeEvent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.beans.IndexedPropertyChangeEvent.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/beans/IndexedPropertyChangeEvent"));
		}
	}
}
