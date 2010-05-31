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
		internal static global::net.sf.jni4net.jni.MethodId _toString6374; 
		public override global::java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.sax.Element._toString6374)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.sax.Element.staticClass, global::android.sax.Element._toString6374)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChild6375; 
		public virtual global::android.sax.Element getChild(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.sax.Element>(@__env, @__env.CallObjectMethodPtr(this, global::android.sax.Element._getChild6375, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.sax.Element>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.sax.Element.staticClass, global::android.sax.Element._getChild6375, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChild6376; 
		public virtual global::android.sax.Element getChild(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.sax.Element>(@__env, @__env.CallObjectMethodPtr(this, global::android.sax.Element._getChild6376, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.sax.Element>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.sax.Element.staticClass, global::android.sax.Element._getChild6376, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requireChild6377; 
		public virtual global::android.sax.Element requireChild(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.sax.Element>(@__env, @__env.CallObjectMethodPtr(this, global::android.sax.Element._requireChild6377, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.sax.Element>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.sax.Element.staticClass, global::android.sax.Element._requireChild6377, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requireChild6378; 
		public virtual global::android.sax.Element requireChild(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.sax.Element>(@__env, @__env.CallObjectMethodPtr(this, global::android.sax.Element._requireChild6378, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.sax.Element>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.sax.Element.staticClass, global::android.sax.Element._requireChild6378, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setElementListener6379; 
		public virtual void setElementListener(android.sax.ElementListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.sax.Element._setElementListener6379, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.sax.Element.staticClass, global::android.sax.Element._setElementListener6379, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTextElementListener6380; 
		public virtual void setTextElementListener(android.sax.TextElementListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.sax.Element._setTextElementListener6380, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.sax.Element.staticClass, global::android.sax.Element._setTextElementListener6380, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStartElementListener6381; 
		public virtual void setStartElementListener(android.sax.StartElementListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.sax.Element._setStartElementListener6381, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.sax.Element.staticClass, global::android.sax.Element._setStartElementListener6381, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEndElementListener6382; 
		public virtual void setEndElementListener(android.sax.EndElementListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.sax.Element._setEndElementListener6382, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.sax.Element.staticClass, global::android.sax.Element._setEndElementListener6382, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEndTextElementListener6383; 
		public virtual void setEndTextElementListener(android.sax.EndTextElementListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.sax.Element._setEndTextElementListener6383, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.sax.Element.staticClass, global::android.sax.Element._setEndTextElementListener6383, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.sax.Element.staticClass = @__class; 
			global::android.sax.Element._toString6374 = @__env.GetMethodID(global::android.sax.Element.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.sax.Element._getChild6375 = @__env.GetMethodID(global::android.sax.Element.staticClass, "getChild", "(Ljava/lang/String;Ljava/lang/String;)Landroid/sax/Element;"); 
			global::android.sax.Element._getChild6376 = @__env.GetMethodID(global::android.sax.Element.staticClass, "getChild", "(Ljava/lang/String;)Landroid/sax/Element;"); 
			global::android.sax.Element._requireChild6377 = @__env.GetMethodID(global::android.sax.Element.staticClass, "requireChild", "(Ljava/lang/String;)Landroid/sax/Element;"); 
			global::android.sax.Element._requireChild6378 = @__env.GetMethodID(global::android.sax.Element.staticClass, "requireChild", "(Ljava/lang/String;Ljava/lang/String;)Landroid/sax/Element;"); 
			global::android.sax.Element._setElementListener6379 = @__env.GetMethodID(global::android.sax.Element.staticClass, "setElementListener", "(Landroid/sax/ElementListener;)V"); 
			global::android.sax.Element._setTextElementListener6380 = @__env.GetMethodID(global::android.sax.Element.staticClass, "setTextElementListener", "(Landroid/sax/TextElementListener;)V"); 
			global::android.sax.Element._setStartElementListener6381 = @__env.GetMethodID(global::android.sax.Element.staticClass, "setStartElementListener", "(Landroid/sax/StartElementListener;)V"); 
			global::android.sax.Element._setEndElementListener6382 = @__env.GetMethodID(global::android.sax.Element.staticClass, "setEndElementListener", "(Landroid/sax/EndElementListener;)V"); 
			global::android.sax.Element._setEndTextElementListener6383 = @__env.GetMethodID(global::android.sax.Element.staticClass, "setEndTextElementListener", "(Landroid/sax/EndTextElementListener;)V"); 
		} 
	} 
} 
