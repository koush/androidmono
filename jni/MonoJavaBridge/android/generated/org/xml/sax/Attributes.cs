namespace org.xml.sax
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.xml.sax.Attributes_))]
	public interface Attributes  : global::MonoJavaBridge.IJavaObject 
	{
		int getLength();
		global::java.lang.String getValue(java.lang.String arg0);
		global::java.lang.String getValue(int arg0);
		global::java.lang.String getValue(java.lang.String arg0, java.lang.String arg1);
		global::java.lang.String getType(int arg0);
		global::java.lang.String getType(java.lang.String arg0, java.lang.String arg1);
		global::java.lang.String getType(java.lang.String arg0);
		int getIndex(java.lang.String arg0);
		int getIndex(java.lang.String arg0, java.lang.String arg1);
		global::java.lang.String getQName(int arg0);
		global::java.lang.String getLocalName(int arg0);
		global::java.lang.String getURI(int arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.xml.sax.Attributes))]
	public sealed partial class Attributes_ : java.lang.Object, Attributes
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Attributes_()
		{
			InitJNI();
		}
		internal Attributes_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getLength28080;
		 int org.xml.sax.Attributes.getLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xml.sax.Attributes_._getLength28080);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xml.sax.Attributes_.staticClass, global::org.xml.sax.Attributes_._getLength28080);
		}
		internal static global::MonoJavaBridge.MethodId _getValue28081;
		 global::java.lang.String org.xml.sax.Attributes.getValue(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.Attributes_._getValue28081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.Attributes_.staticClass, global::org.xml.sax.Attributes_._getValue28081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue28082;
		 global::java.lang.String org.xml.sax.Attributes.getValue(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.Attributes_._getValue28082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.Attributes_.staticClass, global::org.xml.sax.Attributes_._getValue28082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue28083;
		 global::java.lang.String org.xml.sax.Attributes.getValue(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.Attributes_._getValue28083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.Attributes_.staticClass, global::org.xml.sax.Attributes_._getValue28083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType28084;
		 global::java.lang.String org.xml.sax.Attributes.getType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.Attributes_._getType28084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.Attributes_.staticClass, global::org.xml.sax.Attributes_._getType28084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType28085;
		 global::java.lang.String org.xml.sax.Attributes.getType(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.Attributes_._getType28085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.Attributes_.staticClass, global::org.xml.sax.Attributes_._getType28085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType28086;
		 global::java.lang.String org.xml.sax.Attributes.getType(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.Attributes_._getType28086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.Attributes_.staticClass, global::org.xml.sax.Attributes_._getType28086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getIndex28087;
		 int org.xml.sax.Attributes.getIndex(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xml.sax.Attributes_._getIndex28087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xml.sax.Attributes_.staticClass, global::org.xml.sax.Attributes_._getIndex28087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getIndex28088;
		 int org.xml.sax.Attributes.getIndex(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xml.sax.Attributes_._getIndex28088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xml.sax.Attributes_.staticClass, global::org.xml.sax.Attributes_._getIndex28088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getQName28089;
		 global::java.lang.String org.xml.sax.Attributes.getQName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.Attributes_._getQName28089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.Attributes_.staticClass, global::org.xml.sax.Attributes_._getQName28089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalName28090;
		 global::java.lang.String org.xml.sax.Attributes.getLocalName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.Attributes_._getLocalName28090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.Attributes_.staticClass, global::org.xml.sax.Attributes_._getLocalName28090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getURI28091;
		 global::java.lang.String org.xml.sax.Attributes.getURI(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.Attributes_._getURI28091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.Attributes_.staticClass, global::org.xml.sax.Attributes_._getURI28091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.Attributes_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/Attributes"));
			global::org.xml.sax.Attributes_._getLength28080 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Attributes_.staticClass, "getLength", "()I");
			global::org.xml.sax.Attributes_._getValue28081 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Attributes_.staticClass, "getValue", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.xml.sax.Attributes_._getValue28082 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Attributes_.staticClass, "getValue", "(I)Ljava/lang/String;");
			global::org.xml.sax.Attributes_._getValue28083 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Attributes_.staticClass, "getValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::org.xml.sax.Attributes_._getType28084 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Attributes_.staticClass, "getType", "(I)Ljava/lang/String;");
			global::org.xml.sax.Attributes_._getType28085 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Attributes_.staticClass, "getType", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::org.xml.sax.Attributes_._getType28086 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Attributes_.staticClass, "getType", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.xml.sax.Attributes_._getIndex28087 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Attributes_.staticClass, "getIndex", "(Ljava/lang/String;)I");
			global::org.xml.sax.Attributes_._getIndex28088 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Attributes_.staticClass, "getIndex", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::org.xml.sax.Attributes_._getQName28089 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Attributes_.staticClass, "getQName", "(I)Ljava/lang/String;");
			global::org.xml.sax.Attributes_._getLocalName28090 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Attributes_.staticClass, "getLocalName", "(I)Ljava/lang/String;");
			global::org.xml.sax.Attributes_._getURI28091 = @__env.GetMethodIDNoThrow(global::org.xml.sax.Attributes_.staticClass, "getURI", "(I)Ljava/lang/String;");
		}
	}
}
