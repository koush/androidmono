namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.UserDataHandler_))]
	public partial interface UserDataHandler  : global::MonoJavaBridge.IJavaObject 
	{
		void handle(short arg0, java.lang.String arg1, java.lang.Object arg2, org.w3c.dom.Node arg3, org.w3c.dom.Node arg4);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.UserDataHandler))]
	internal sealed partial class UserDataHandler_ : java.lang.Object, UserDataHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal UserDataHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _handle34876;
		void org.w3c.dom.UserDataHandler.handle(short arg0, java.lang.String arg1, java.lang.Object arg2, org.w3c.dom.Node arg3, org.w3c.dom.Node arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.w3c.dom.UserDataHandler_.staticClass, "handle", "(SLjava/lang/String;Ljava/lang/Object;Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)V", ref global::org.w3c.dom.UserDataHandler_._handle34876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		static UserDataHandler_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.UserDataHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/UserDataHandler"));
		}
		internal static void InitJNI()
		{
		}
	}
}
