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
		internal static global::MonoJavaBridge.MethodId _comment35011;
		 void org.xml.sax.ext.LexicalHandler.comment(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.LexicalHandler_._comment35011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.LexicalHandler_.staticClass, global::org.xml.sax.ext.LexicalHandler_._comment35011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _startCDATA35012;
		 void org.xml.sax.ext.LexicalHandler.startCDATA() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.LexicalHandler_._startCDATA35012);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.LexicalHandler_.staticClass, global::org.xml.sax.ext.LexicalHandler_._startCDATA35012);
		}
		internal static global::MonoJavaBridge.MethodId _endCDATA35013;
		 void org.xml.sax.ext.LexicalHandler.endCDATA() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.LexicalHandler_._endCDATA35013);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.LexicalHandler_.staticClass, global::org.xml.sax.ext.LexicalHandler_._endCDATA35013);
		}
		internal static global::MonoJavaBridge.MethodId _startEntity35014;
		 void org.xml.sax.ext.LexicalHandler.startEntity(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.LexicalHandler_._startEntity35014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.LexicalHandler_.staticClass, global::org.xml.sax.ext.LexicalHandler_._startEntity35014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _endEntity35015;
		 void org.xml.sax.ext.LexicalHandler.endEntity(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.LexicalHandler_._endEntity35015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.LexicalHandler_.staticClass, global::org.xml.sax.ext.LexicalHandler_._endEntity35015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startDTD35016;
		 void org.xml.sax.ext.LexicalHandler.startDTD(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.LexicalHandler_._startDTD35016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.LexicalHandler_.staticClass, global::org.xml.sax.ext.LexicalHandler_._startDTD35016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _endDTD35017;
		 void org.xml.sax.ext.LexicalHandler.endDTD() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.LexicalHandler_._endDTD35017);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.LexicalHandler_.staticClass, global::org.xml.sax.ext.LexicalHandler_._endDTD35017);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.ext.LexicalHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/ext/LexicalHandler"));
			global::org.xml.sax.ext.LexicalHandler_._comment35011 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.LexicalHandler_.staticClass, "comment", "([CII)V");
			global::org.xml.sax.ext.LexicalHandler_._startCDATA35012 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.LexicalHandler_.staticClass, "startCDATA", "()V");
			global::org.xml.sax.ext.LexicalHandler_._endCDATA35013 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.LexicalHandler_.staticClass, "endCDATA", "()V");
			global::org.xml.sax.ext.LexicalHandler_._startEntity35014 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.LexicalHandler_.staticClass, "startEntity", "(Ljava/lang/String;)V");
			global::org.xml.sax.ext.LexicalHandler_._endEntity35015 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.LexicalHandler_.staticClass, "endEntity", "(Ljava/lang/String;)V");
			global::org.xml.sax.ext.LexicalHandler_._startDTD35016 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.LexicalHandler_.staticClass, "startDTD", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.ext.LexicalHandler_._endDTD35017 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.LexicalHandler_.staticClass, "endDTD", "()V");
		}
	}
}
