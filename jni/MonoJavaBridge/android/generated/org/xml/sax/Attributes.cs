namespace org.xml.sax
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface Attributes 
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

	public partial class Attributes_
	{
		public static global::java.lang.Class _class
		{
			get { return __Attributes.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __Attributes : java.lang.Object, Attributes
	{
		internal static global::java.lang.Class staticClass;
		static __Attributes()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.xml.sax.__Attributes), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.xml.sax.__Attributes(@__env);
			}
		}
		internal __Attributes(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLength13277;
		 int org.xml.sax.Attributes.getLength() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::org.xml.sax.__Attributes._getLength13277);
			else
				return @__env.CallNonVirtualIntMethod(this, global::org.xml.sax.__Attributes.staticClass, global::org.xml.sax.__Attributes._getLength13277);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getValue13278;
		 global::java.lang.String org.xml.sax.Attributes.getValue(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xml.sax.__Attributes._getValue13278, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xml.sax.__Attributes.staticClass, global::org.xml.sax.__Attributes._getValue13278, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getValue13279;
		 global::java.lang.String org.xml.sax.Attributes.getValue(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xml.sax.__Attributes._getValue13279, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xml.sax.__Attributes.staticClass, global::org.xml.sax.__Attributes._getValue13279, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getValue13280;
		 global::java.lang.String org.xml.sax.Attributes.getValue(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xml.sax.__Attributes._getValue13280, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xml.sax.__Attributes.staticClass, global::org.xml.sax.__Attributes._getValue13280, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getType13281;
		 global::java.lang.String org.xml.sax.Attributes.getType(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xml.sax.__Attributes._getType13281, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xml.sax.__Attributes.staticClass, global::org.xml.sax.__Attributes._getType13281, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getType13282;
		 global::java.lang.String org.xml.sax.Attributes.getType(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xml.sax.__Attributes._getType13282, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xml.sax.__Attributes.staticClass, global::org.xml.sax.__Attributes._getType13282, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getType13283;
		 global::java.lang.String org.xml.sax.Attributes.getType(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xml.sax.__Attributes._getType13283, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xml.sax.__Attributes.staticClass, global::org.xml.sax.__Attributes._getType13283, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIndex13284;
		 int org.xml.sax.Attributes.getIndex(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::org.xml.sax.__Attributes._getIndex13284, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::org.xml.sax.__Attributes.staticClass, global::org.xml.sax.__Attributes._getIndex13284, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIndex13285;
		 int org.xml.sax.Attributes.getIndex(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::org.xml.sax.__Attributes._getIndex13285, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::org.xml.sax.__Attributes.staticClass, global::org.xml.sax.__Attributes._getIndex13285, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getQName13286;
		 global::java.lang.String org.xml.sax.Attributes.getQName(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xml.sax.__Attributes._getQName13286, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xml.sax.__Attributes.staticClass, global::org.xml.sax.__Attributes._getQName13286, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLocalName13287;
		 global::java.lang.String org.xml.sax.Attributes.getLocalName(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xml.sax.__Attributes._getLocalName13287, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xml.sax.__Attributes.staticClass, global::org.xml.sax.__Attributes._getLocalName13287, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getURI13288;
		 global::java.lang.String org.xml.sax.Attributes.getURI(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::org.xml.sax.__Attributes._getURI13288, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.xml.sax.__Attributes.staticClass, global::org.xml.sax.__Attributes._getURI13288, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.xml.sax.__Attributes.staticClass = @__class;
			global::org.xml.sax.__Attributes._getLength13277 = @__env.GetMethodID(global::org.xml.sax.__Attributes.staticClass, "org.xml.sax.Attributes.getLength", "()I");
			global::org.xml.sax.__Attributes._getValue13278 = @__env.GetMethodID(global::org.xml.sax.__Attributes.staticClass, "org.xml.sax.Attributes.getValue", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.xml.sax.__Attributes._getValue13279 = @__env.GetMethodID(global::org.xml.sax.__Attributes.staticClass, "org.xml.sax.Attributes.getValue", "(I)Ljava/lang/String;");
			global::org.xml.sax.__Attributes._getValue13280 = @__env.GetMethodID(global::org.xml.sax.__Attributes.staticClass, "org.xml.sax.Attributes.getValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::org.xml.sax.__Attributes._getType13281 = @__env.GetMethodID(global::org.xml.sax.__Attributes.staticClass, "org.xml.sax.Attributes.getType", "(I)Ljava/lang/String;");
			global::org.xml.sax.__Attributes._getType13282 = @__env.GetMethodID(global::org.xml.sax.__Attributes.staticClass, "org.xml.sax.Attributes.getType", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::org.xml.sax.__Attributes._getType13283 = @__env.GetMethodID(global::org.xml.sax.__Attributes.staticClass, "org.xml.sax.Attributes.getType", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.xml.sax.__Attributes._getIndex13284 = @__env.GetMethodID(global::org.xml.sax.__Attributes.staticClass, "org.xml.sax.Attributes.getIndex", "(Ljava/lang/String;)I");
			global::org.xml.sax.__Attributes._getIndex13285 = @__env.GetMethodID(global::org.xml.sax.__Attributes.staticClass, "org.xml.sax.Attributes.getIndex", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::org.xml.sax.__Attributes._getQName13286 = @__env.GetMethodID(global::org.xml.sax.__Attributes.staticClass, "org.xml.sax.Attributes.getQName", "(I)Ljava/lang/String;");
			global::org.xml.sax.__Attributes._getLocalName13287 = @__env.GetMethodID(global::org.xml.sax.__Attributes.staticClass, "org.xml.sax.Attributes.getLocalName", "(I)Ljava/lang/String;");
			global::org.xml.sax.__Attributes._getURI13288 = @__env.GetMethodID(global::org.xml.sax.__Attributes.staticClass, "org.xml.sax.Attributes.getURI", "(I)Ljava/lang/String;");
		}
	}
}
