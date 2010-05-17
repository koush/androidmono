namespace android.sax 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Element : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Element() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.sax.Element), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _toString6095; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.sax.Element)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString6095)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.sax.Element.staticClass, _toString6095)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChild6096; 
		public virtual android.sax.Element getChild(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.sax.Element)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.sax.Element>(@__env, @__env.CallObjectMethodPtr(this, _getChild6096, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.sax.Element>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.sax.Element.staticClass, _getChild6096, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChild6097; 
		public virtual android.sax.Element getChild(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.sax.Element)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.sax.Element>(@__env, @__env.CallObjectMethodPtr(this, _getChild6097, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.sax.Element>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.sax.Element.staticClass, _getChild6097, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requireChild6098; 
		public virtual android.sax.Element requireChild(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.sax.Element)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.sax.Element>(@__env, @__env.CallObjectMethodPtr(this, _requireChild6098, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.sax.Element>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.sax.Element.staticClass, _requireChild6098, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requireChild6099; 
		public virtual android.sax.Element requireChild(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.sax.Element)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.sax.Element>(@__env, @__env.CallObjectMethodPtr(this, _requireChild6099, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.sax.Element>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.sax.Element.staticClass, _requireChild6099, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setElementListener6100; 
		public virtual void setElementListener(android.sax.ElementListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.sax.Element)) 
				@__env.CallVoidMethod(this, _setElementListener6100, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.sax.Element.staticClass, _setElementListener6100, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTextElementListener6101; 
		public virtual void setTextElementListener(android.sax.TextElementListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.sax.Element)) 
				@__env.CallVoidMethod(this, _setTextElementListener6101, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.sax.Element.staticClass, _setTextElementListener6101, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStartElementListener6102; 
		public virtual void setStartElementListener(android.sax.StartElementListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.sax.Element)) 
				@__env.CallVoidMethod(this, _setStartElementListener6102, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.sax.Element.staticClass, _setStartElementListener6102, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEndElementListener6103; 
		public virtual void setEndElementListener(android.sax.EndElementListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.sax.Element)) 
				@__env.CallVoidMethod(this, _setEndElementListener6103, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.sax.Element.staticClass, _setEndElementListener6103, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEndTextElementListener6104; 
		public virtual void setEndTextElementListener(android.sax.EndTextElementListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.sax.Element)) 
				@__env.CallVoidMethod(this, _setEndTextElementListener6104, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.sax.Element.staticClass, _setEndTextElementListener6104, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.sax.Element.staticClass = @__class; 
			global::android.sax.Element._toString6095 = @__env.GetMethodID(global::android.sax.Element.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.sax.Element._getChild6096 = @__env.GetMethodID(global::android.sax.Element.staticClass, "getChild", "(Ljava/lang/String;Ljava/lang/String;)Landroid/sax/Element;"); 
			global::android.sax.Element._getChild6097 = @__env.GetMethodID(global::android.sax.Element.staticClass, "getChild", "(Ljava/lang/String;)Landroid/sax/Element;"); 
			global::android.sax.Element._requireChild6098 = @__env.GetMethodID(global::android.sax.Element.staticClass, "requireChild", "(Ljava/lang/String;)Landroid/sax/Element;"); 
			global::android.sax.Element._requireChild6099 = @__env.GetMethodID(global::android.sax.Element.staticClass, "requireChild", "(Ljava/lang/String;Ljava/lang/String;)Landroid/sax/Element;"); 
			global::android.sax.Element._setElementListener6100 = @__env.GetMethodID(global::android.sax.Element.staticClass, "setElementListener", "(Landroid/sax/ElementListener;)V"); 
			global::android.sax.Element._setTextElementListener6101 = @__env.GetMethodID(global::android.sax.Element.staticClass, "setTextElementListener", "(Landroid/sax/TextElementListener;)V"); 
			global::android.sax.Element._setStartElementListener6102 = @__env.GetMethodID(global::android.sax.Element.staticClass, "setStartElementListener", "(Landroid/sax/StartElementListener;)V"); 
			global::android.sax.Element._setEndElementListener6103 = @__env.GetMethodID(global::android.sax.Element.staticClass, "setEndElementListener", "(Landroid/sax/EndElementListener;)V"); 
			global::android.sax.Element._setEndTextElementListener6104 = @__env.GetMethodID(global::android.sax.Element.staticClass, "setEndTextElementListener", "(Landroid/sax/EndTextElementListener;)V"); 
		} 
	} 
} 
