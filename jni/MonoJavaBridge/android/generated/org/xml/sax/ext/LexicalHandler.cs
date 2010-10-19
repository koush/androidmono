namespace org.xml.sax.ext
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.xml.sax.ext.LexicalHandler_))]
	public interface LexicalHandler  : global::MonoJavaBridge.IJavaObject 
	{
		void comment(char[] arg0, int arg1, int arg2);
		void startCDATA();
		void endCDATA();
		void startEntity(java.lang.String arg0);
		void endEntity(java.lang.String arg0);
		void startDTD(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2);
		void endDTD();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.xml.sax.ext.LexicalHandler))]
	public sealed partial class LexicalHandler_ : java.lang.Object, LexicalHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LexicalHandler_()
		{
			InitJNI();
		}
		internal LexicalHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _comment28260;
		 void org.xml.sax.ext.LexicalHandler.comment(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.LexicalHandler_._comment28260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.LexicalHandler_.staticClass, global::org.xml.sax.ext.LexicalHandler_._comment28260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _startCDATA28261;
		 void org.xml.sax.ext.LexicalHandler.startCDATA() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.LexicalHandler_._startCDATA28261);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.LexicalHandler_.staticClass, global::org.xml.sax.ext.LexicalHandler_._startCDATA28261);
		}
		internal static global::MonoJavaBridge.MethodId _endCDATA28262;
		 void org.xml.sax.ext.LexicalHandler.endCDATA() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.LexicalHandler_._endCDATA28262);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.LexicalHandler_.staticClass, global::org.xml.sax.ext.LexicalHandler_._endCDATA28262);
		}
		internal static global::MonoJavaBridge.MethodId _startEntity28263;
		 void org.xml.sax.ext.LexicalHandler.startEntity(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.LexicalHandler_._startEntity28263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.LexicalHandler_.staticClass, global::org.xml.sax.ext.LexicalHandler_._startEntity28263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _endEntity28264;
		 void org.xml.sax.ext.LexicalHandler.endEntity(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.LexicalHandler_._endEntity28264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.LexicalHandler_.staticClass, global::org.xml.sax.ext.LexicalHandler_._endEntity28264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startDTD28265;
		 void org.xml.sax.ext.LexicalHandler.startDTD(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.LexicalHandler_._startDTD28265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.LexicalHandler_.staticClass, global::org.xml.sax.ext.LexicalHandler_._startDTD28265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _endDTD28266;
		 void org.xml.sax.ext.LexicalHandler.endDTD() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.LexicalHandler_._endDTD28266);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.LexicalHandler_.staticClass, global::org.xml.sax.ext.LexicalHandler_._endDTD28266);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.ext.LexicalHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/ext/LexicalHandler"));
			global::org.xml.sax.ext.LexicalHandler_._comment28260 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.LexicalHandler_.staticClass, "comment", "([CII)V");
			global::org.xml.sax.ext.LexicalHandler_._startCDATA28261 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.LexicalHandler_.staticClass, "startCDATA", "()V");
			global::org.xml.sax.ext.LexicalHandler_._endCDATA28262 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.LexicalHandler_.staticClass, "endCDATA", "()V");
			global::org.xml.sax.ext.LexicalHandler_._startEntity28263 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.LexicalHandler_.staticClass, "startEntity", "(Ljava/lang/String;)V");
			global::org.xml.sax.ext.LexicalHandler_._endEntity28264 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.LexicalHandler_.staticClass, "endEntity", "(Ljava/lang/String;)V");
			global::org.xml.sax.ext.LexicalHandler_._startDTD28265 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.LexicalHandler_.staticClass, "startDTD", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.ext.LexicalHandler_._endDTD28266 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.LexicalHandler_.staticClass, "endDTD", "()V");
		}
	}
}
