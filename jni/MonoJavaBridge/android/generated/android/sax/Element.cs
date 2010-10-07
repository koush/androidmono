namespace android.sax
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Element : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Element()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.sax.Element), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.sax.Element(@__env);
			}
		}
		protected Element(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString6963;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.sax.Element._toString6963));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.sax.Element.staticClass, global::android.sax.Element._toString6963));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChild6964;
		public virtual global::android.sax.Element getChild(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.sax.Element>(@__env, @__env.CallObjectMethodPtr(this, global::android.sax.Element._getChild6964, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.sax.Element>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.sax.Element.staticClass, global::android.sax.Element._getChild6964, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChild6965;
		public virtual global::android.sax.Element getChild(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.sax.Element>(@__env, @__env.CallObjectMethodPtr(this, global::android.sax.Element._getChild6965, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.sax.Element>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.sax.Element.staticClass, global::android.sax.Element._getChild6965, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requireChild6966;
		public virtual global::android.sax.Element requireChild(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.sax.Element>(@__env, @__env.CallObjectMethodPtr(this, global::android.sax.Element._requireChild6966, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.sax.Element>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.sax.Element.staticClass, global::android.sax.Element._requireChild6966, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requireChild6967;
		public virtual global::android.sax.Element requireChild(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.sax.Element>(@__env, @__env.CallObjectMethodPtr(this, global::android.sax.Element._requireChild6967, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.sax.Element>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.sax.Element.staticClass, global::android.sax.Element._requireChild6967, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setElementListener6968;
		public virtual void setElementListener(android.sax.ElementListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.sax.Element._setElementListener6968, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.sax.Element.staticClass, global::android.sax.Element._setElementListener6968, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTextElementListener6969;
		public virtual void setTextElementListener(android.sax.TextElementListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.sax.Element._setTextElementListener6969, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.sax.Element.staticClass, global::android.sax.Element._setTextElementListener6969, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setStartElementListener6970;
		public virtual void setStartElementListener(android.sax.StartElementListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.sax.Element._setStartElementListener6970, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.sax.Element.staticClass, global::android.sax.Element._setStartElementListener6970, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setEndElementListener6971;
		public virtual void setEndElementListener(android.sax.EndElementListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.sax.Element._setEndElementListener6971, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.sax.Element.staticClass, global::android.sax.Element._setEndElementListener6971, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setEndTextElementListener6972;
		public virtual void setEndTextElementListener(android.sax.EndTextElementListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.sax.Element._setEndTextElementListener6972, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.sax.Element.staticClass, global::android.sax.Element._setEndTextElementListener6972, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.sax.Element.staticClass = @__class;
			global::android.sax.Element._toString6963 = @__env.GetMethodID(global::android.sax.Element.staticClass, "toString", "()Ljava/lang/String;");
			global::android.sax.Element._getChild6964 = @__env.GetMethodID(global::android.sax.Element.staticClass, "getChild", "(Ljava/lang/String;Ljava/lang/String;)Landroid/sax/Element;");
			global::android.sax.Element._getChild6965 = @__env.GetMethodID(global::android.sax.Element.staticClass, "getChild", "(Ljava/lang/String;)Landroid/sax/Element;");
			global::android.sax.Element._requireChild6966 = @__env.GetMethodID(global::android.sax.Element.staticClass, "requireChild", "(Ljava/lang/String;)Landroid/sax/Element;");
			global::android.sax.Element._requireChild6967 = @__env.GetMethodID(global::android.sax.Element.staticClass, "requireChild", "(Ljava/lang/String;Ljava/lang/String;)Landroid/sax/Element;");
			global::android.sax.Element._setElementListener6968 = @__env.GetMethodID(global::android.sax.Element.staticClass, "setElementListener", "(Landroid/sax/ElementListener;)V");
			global::android.sax.Element._setTextElementListener6969 = @__env.GetMethodID(global::android.sax.Element.staticClass, "setTextElementListener", "(Landroid/sax/TextElementListener;)V");
			global::android.sax.Element._setStartElementListener6970 = @__env.GetMethodID(global::android.sax.Element.staticClass, "setStartElementListener", "(Landroid/sax/StartElementListener;)V");
			global::android.sax.Element._setEndElementListener6971 = @__env.GetMethodID(global::android.sax.Element.staticClass, "setEndElementListener", "(Landroid/sax/EndElementListener;)V");
			global::android.sax.Element._setEndTextElementListener6972 = @__env.GetMethodID(global::android.sax.Element.staticClass, "setEndTextElementListener", "(Landroid/sax/EndTextElementListener;)V");
		}
	}
}
