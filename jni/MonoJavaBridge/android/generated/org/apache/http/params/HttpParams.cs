namespace org.apache.http.@params
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface HttpParams 
	{
		global::org.apache.http.@params.HttpParams copy();
		global::org.apache.http.@params.HttpParams setParameter(java.lang.String arg0, java.lang.Object arg1);
		global::java.lang.Object getParameter(java.lang.String arg0);
		bool removeParameter(java.lang.String arg0);
		long getLongParameter(java.lang.String arg0, long arg1);
		global::org.apache.http.@params.HttpParams setLongParameter(java.lang.String arg0, long arg1);
		int getIntParameter(java.lang.String arg0, int arg1);
		global::org.apache.http.@params.HttpParams setIntParameter(java.lang.String arg0, int arg1);
		double getDoubleParameter(java.lang.String arg0, double arg1);
		global::org.apache.http.@params.HttpParams setDoubleParameter(java.lang.String arg0, double arg1);
		bool getBooleanParameter(java.lang.String arg0, bool arg1);
		global::org.apache.http.@params.HttpParams setBooleanParameter(java.lang.String arg0, bool arg1);
		bool isParameterTrue(java.lang.String arg0);
		bool isParameterFalse(java.lang.String arg0);
	}

	public partial class HttpParams_
	{
		public static global::java.lang.Class _class
		{
			get { return __HttpParams.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __HttpParams : java.lang.Object, HttpParams
	{
		internal static global::java.lang.Class staticClass;
		static __HttpParams()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::org.apache.http.@params.__HttpParams), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::org.apache.http.@params.__HttpParams(@__env);
			}
		}
		internal __HttpParams(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _copy14539;
		 global::org.apache.http.@params.HttpParams org.apache.http.@params.HttpParams.copy() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.@params.HttpParams>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.@params.__HttpParams._copy14539));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.@params.HttpParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.@params.__HttpParams.staticClass, global::org.apache.http.@params.__HttpParams._copy14539));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setParameter14540;
		 global::org.apache.http.@params.HttpParams org.apache.http.@params.HttpParams.setParameter(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.@params.HttpParams>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.@params.__HttpParams._setParameter14540, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.@params.HttpParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.@params.__HttpParams.staticClass, global::org.apache.http.@params.__HttpParams._setParameter14540, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getParameter14541;
		 global::java.lang.Object org.apache.http.@params.HttpParams.getParameter(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.@params.__HttpParams._getParameter14541, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.@params.__HttpParams.staticClass, global::org.apache.http.@params.__HttpParams._getParameter14541, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeParameter14542;
		 bool org.apache.http.@params.HttpParams.removeParameter(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.@params.__HttpParams._removeParameter14542, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.@params.__HttpParams.staticClass, global::org.apache.http.@params.__HttpParams._removeParameter14542, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLongParameter14543;
		 long org.apache.http.@params.HttpParams.getLongParameter(java.lang.String arg0, long arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::org.apache.http.@params.__HttpParams._getLongParameter14543, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this, global::org.apache.http.@params.__HttpParams.staticClass, global::org.apache.http.@params.__HttpParams._getLongParameter14543, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLongParameter14544;
		 global::org.apache.http.@params.HttpParams org.apache.http.@params.HttpParams.setLongParameter(java.lang.String arg0, long arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.@params.HttpParams>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.@params.__HttpParams._setLongParameter14544, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.@params.HttpParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.@params.__HttpParams.staticClass, global::org.apache.http.@params.__HttpParams._setLongParameter14544, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIntParameter14545;
		 int org.apache.http.@params.HttpParams.getIntParameter(java.lang.String arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::org.apache.http.@params.__HttpParams._getIntParameter14545, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::org.apache.http.@params.__HttpParams.staticClass, global::org.apache.http.@params.__HttpParams._getIntParameter14545, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setIntParameter14546;
		 global::org.apache.http.@params.HttpParams org.apache.http.@params.HttpParams.setIntParameter(java.lang.String arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.@params.HttpParams>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.@params.__HttpParams._setIntParameter14546, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.@params.HttpParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.@params.__HttpParams.staticClass, global::org.apache.http.@params.__HttpParams._setIntParameter14546, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDoubleParameter14547;
		 double org.apache.http.@params.HttpParams.getDoubleParameter(java.lang.String arg0, double arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this, global::org.apache.http.@params.__HttpParams._getDoubleParameter14547, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualDoubleMethod(this, global::org.apache.http.@params.__HttpParams.staticClass, global::org.apache.http.@params.__HttpParams._getDoubleParameter14547, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDoubleParameter14548;
		 global::org.apache.http.@params.HttpParams org.apache.http.@params.HttpParams.setDoubleParameter(java.lang.String arg0, double arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.@params.HttpParams>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.@params.__HttpParams._setDoubleParameter14548, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.@params.HttpParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.@params.__HttpParams.staticClass, global::org.apache.http.@params.__HttpParams._setDoubleParameter14548, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBooleanParameter14549;
		 bool org.apache.http.@params.HttpParams.getBooleanParameter(java.lang.String arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.@params.__HttpParams._getBooleanParameter14549, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.@params.__HttpParams.staticClass, global::org.apache.http.@params.__HttpParams._getBooleanParameter14549, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setBooleanParameter14550;
		 global::org.apache.http.@params.HttpParams org.apache.http.@params.HttpParams.setBooleanParameter(java.lang.String arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.@params.HttpParams>(@__env, @__env.CallObjectMethodPtr(this, global::org.apache.http.@params.__HttpParams._setBooleanParameter14550, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.apache.http.@params.HttpParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::org.apache.http.@params.__HttpParams.staticClass, global::org.apache.http.@params.__HttpParams._setBooleanParameter14550, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isParameterTrue14551;
		 bool org.apache.http.@params.HttpParams.isParameterTrue(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.@params.__HttpParams._isParameterTrue14551, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.@params.__HttpParams.staticClass, global::org.apache.http.@params.__HttpParams._isParameterTrue14551, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isParameterFalse14552;
		 bool org.apache.http.@params.HttpParams.isParameterFalse(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::org.apache.http.@params.__HttpParams._isParameterFalse14552, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::org.apache.http.@params.__HttpParams.staticClass, global::org.apache.http.@params.__HttpParams._isParameterFalse14552, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::org.apache.http.@params.__HttpParams.staticClass = @__class;
			global::org.apache.http.@params.__HttpParams._copy14539 = @__env.GetMethodID(global::org.apache.http.@params.__HttpParams.staticClass, "org.apache.http.@params.HttpParams.copy", "()Lorg/apache/http/@params/HttpParams;");
			global::org.apache.http.@params.__HttpParams._setParameter14540 = @__env.GetMethodID(global::org.apache.http.@params.__HttpParams.staticClass, "org.apache.http.@params.HttpParams.setParameter", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/apache/http/@params/HttpParams;");
			global::org.apache.http.@params.__HttpParams._getParameter14541 = @__env.GetMethodID(global::org.apache.http.@params.__HttpParams.staticClass, "org.apache.http.@params.HttpParams.getParameter", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.apache.http.@params.__HttpParams._removeParameter14542 = @__env.GetMethodID(global::org.apache.http.@params.__HttpParams.staticClass, "org.apache.http.@params.HttpParams.removeParameter", "(Ljava/lang/String;)Z");
			global::org.apache.http.@params.__HttpParams._getLongParameter14543 = @__env.GetMethodID(global::org.apache.http.@params.__HttpParams.staticClass, "org.apache.http.@params.HttpParams.getLongParameter", "(Ljava/lang/String;J)J");
			global::org.apache.http.@params.__HttpParams._setLongParameter14544 = @__env.GetMethodID(global::org.apache.http.@params.__HttpParams.staticClass, "org.apache.http.@params.HttpParams.setLongParameter", "(Ljava/lang/String;J)Lorg/apache/http/@params/HttpParams;");
			global::org.apache.http.@params.__HttpParams._getIntParameter14545 = @__env.GetMethodID(global::org.apache.http.@params.__HttpParams.staticClass, "org.apache.http.@params.HttpParams.getIntParameter", "(Ljava/lang/String;I)I");
			global::org.apache.http.@params.__HttpParams._setIntParameter14546 = @__env.GetMethodID(global::org.apache.http.@params.__HttpParams.staticClass, "org.apache.http.@params.HttpParams.setIntParameter", "(Ljava/lang/String;I)Lorg/apache/http/@params/HttpParams;");
			global::org.apache.http.@params.__HttpParams._getDoubleParameter14547 = @__env.GetMethodID(global::org.apache.http.@params.__HttpParams.staticClass, "org.apache.http.@params.HttpParams.getDoubleParameter", "(Ljava/lang/String;D)D");
			global::org.apache.http.@params.__HttpParams._setDoubleParameter14548 = @__env.GetMethodID(global::org.apache.http.@params.__HttpParams.staticClass, "org.apache.http.@params.HttpParams.setDoubleParameter", "(Ljava/lang/String;D)Lorg/apache/http/@params/HttpParams;");
			global::org.apache.http.@params.__HttpParams._getBooleanParameter14549 = @__env.GetMethodID(global::org.apache.http.@params.__HttpParams.staticClass, "org.apache.http.@params.HttpParams.getBooleanParameter", "(Ljava/lang/String;Z)Z");
			global::org.apache.http.@params.__HttpParams._setBooleanParameter14550 = @__env.GetMethodID(global::org.apache.http.@params.__HttpParams.staticClass, "org.apache.http.@params.HttpParams.setBooleanParameter", "(Ljava/lang/String;Z)Lorg/apache/http/@params/HttpParams;");
			global::org.apache.http.@params.__HttpParams._isParameterTrue14551 = @__env.GetMethodID(global::org.apache.http.@params.__HttpParams.staticClass, "org.apache.http.@params.HttpParams.isParameterTrue", "(Ljava/lang/String;)Z");
			global::org.apache.http.@params.__HttpParams._isParameterFalse14552 = @__env.GetMethodID(global::org.apache.http.@params.__HttpParams.staticClass, "org.apache.http.@params.HttpParams.isParameterFalse", "(Ljava/lang/String;)Z");
		}
	}
}
