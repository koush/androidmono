namespace java.beans
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IndexedPropertyChangeEvent : java.beans.PropertyChangeEvent
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static IndexedPropertyChangeEvent()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getIndex13184;
		public virtual int getIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.beans.IndexedPropertyChangeEvent._getIndex13184);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.beans.IndexedPropertyChangeEvent.staticClass, global::java.beans.IndexedPropertyChangeEvent._getIndex13184);
		}
		internal static global::MonoJavaBridge.MethodId _IndexedPropertyChangeEvent13185;
		public IndexedPropertyChangeEvent(java.lang.Object arg0, java.lang.String arg1, java.lang.Object arg2, java.lang.Object arg3, int arg4)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.beans.IndexedPropertyChangeEvent.staticClass, global::java.beans.IndexedPropertyChangeEvent._IndexedPropertyChangeEvent13185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.beans.IndexedPropertyChangeEvent.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/beans/IndexedPropertyChangeEvent"));
			global::java.beans.IndexedPropertyChangeEvent._getIndex13184 = @__env.GetMethodIDNoThrow(global::java.beans.IndexedPropertyChangeEvent.staticClass, "getIndex", "()I");
			global::java.beans.IndexedPropertyChangeEvent._IndexedPropertyChangeEvent13185 = @__env.GetMethodIDNoThrow(global::java.beans.IndexedPropertyChangeEvent.staticClass, "<init>", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;I)V");
		}
	}
}
