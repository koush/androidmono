namespace android.sax
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Element : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Element(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString11598;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.sax.Element.staticClass, "toString", "()Ljava/lang/String;", ref global::android.sax.Element._toString11598) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getChild11599;
		public virtual global::android.sax.Element getChild(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.sax.Element.staticClass, "getChild", "(Ljava/lang/String;Ljava/lang/String;)Landroid/sax/Element;", ref global::android.sax.Element._getChild11599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.sax.Element;
		}
		internal static global::MonoJavaBridge.MethodId _getChild11600;
		public virtual global::android.sax.Element getChild(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.sax.Element.staticClass, "getChild", "(Ljava/lang/String;)Landroid/sax/Element;", ref global::android.sax.Element._getChild11600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.sax.Element;
		}
		internal static global::MonoJavaBridge.MethodId _requireChild11601;
		public virtual global::android.sax.Element requireChild(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.sax.Element.staticClass, "requireChild", "(Ljava/lang/String;)Landroid/sax/Element;", ref global::android.sax.Element._requireChild11601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.sax.Element;
		}
		internal static global::MonoJavaBridge.MethodId _requireChild11602;
		public virtual global::android.sax.Element requireChild(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.sax.Element.staticClass, "requireChild", "(Ljava/lang/String;Ljava/lang/String;)Landroid/sax/Element;", ref global::android.sax.Element._requireChild11602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.sax.Element;
		}
		public new global::android.sax.ElementListener ElementListener
		{
			set
			{
				setElementListener(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setElementListener11603;
		public virtual void setElementListener(android.sax.ElementListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.sax.Element.staticClass, "setElementListener", "(Landroid/sax/ElementListener;)V", ref global::android.sax.Element._setElementListener11603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.sax.TextElementListener TextElementListener
		{
			set
			{
				setTextElementListener(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setTextElementListener11604;
		public virtual void setTextElementListener(android.sax.TextElementListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.sax.Element.staticClass, "setTextElementListener", "(Landroid/sax/TextElementListener;)V", ref global::android.sax.Element._setTextElementListener11604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.sax.StartElementListener StartElementListener
		{
			set
			{
				setStartElementListener(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setStartElementListener11605;
		public virtual void setStartElementListener(android.sax.StartElementListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.sax.Element.staticClass, "setStartElementListener", "(Landroid/sax/StartElementListener;)V", ref global::android.sax.Element._setStartElementListener11605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setStartElementListener(global::android.sax.StartElementListenerDelegate arg0)
		{
			setStartElementListener((global::android.sax.StartElementListenerDelegateWrapper)arg0);
		}
		public new global::android.sax.EndElementListener EndElementListener
		{
			set
			{
				setEndElementListener(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setEndElementListener11606;
		public virtual void setEndElementListener(android.sax.EndElementListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.sax.Element.staticClass, "setEndElementListener", "(Landroid/sax/EndElementListener;)V", ref global::android.sax.Element._setEndElementListener11606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setEndElementListener(global::android.sax.EndElementListenerDelegate arg0)
		{
			setEndElementListener((global::android.sax.EndElementListenerDelegateWrapper)arg0);
		}
		public new global::android.sax.EndTextElementListener EndTextElementListener
		{
			set
			{
				setEndTextElementListener(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setEndTextElementListener11607;
		public virtual void setEndTextElementListener(android.sax.EndTextElementListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.sax.Element.staticClass, "setEndTextElementListener", "(Landroid/sax/EndTextElementListener;)V", ref global::android.sax.Element._setEndTextElementListener11607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setEndTextElementListener(global::android.sax.EndTextElementListenerDelegate arg0)
		{
			setEndTextElementListener((global::android.sax.EndTextElementListenerDelegateWrapper)arg0);
		}
		static Element()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.sax.Element.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/sax/Element"));
		}
		internal static void InitJNI()
		{
		}
	}
}
