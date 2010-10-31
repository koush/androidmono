namespace android.sax
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Element : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Element(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.sax.Element.staticClass, "toString", "()Ljava/lang/String;", ref global::android.sax.Element._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::android.sax.Element getChild(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.sax.Element.staticClass, "getChild", "(Ljava/lang/String;Ljava/lang/String;)Landroid/sax/Element;", ref global::android.sax.Element._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.sax.Element;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::android.sax.Element getChild(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.sax.Element.staticClass, "getChild", "(Ljava/lang/String;)Landroid/sax/Element;", ref global::android.sax.Element._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.sax.Element;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::android.sax.Element requireChild(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.sax.Element.staticClass, "requireChild", "(Ljava/lang/String;)Landroid/sax/Element;", ref global::android.sax.Element._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.sax.Element;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::android.sax.Element requireChild(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.sax.Element.staticClass, "requireChild", "(Ljava/lang/String;Ljava/lang/String;)Landroid/sax/Element;", ref global::android.sax.Element._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.sax.Element;
		}
		public new global::android.sax.ElementListener ElementListener
		{
			set
			{
				setElementListener(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setElementListener(android.sax.ElementListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.sax.Element.staticClass, "setElementListener", "(Landroid/sax/ElementListener;)V", ref global::android.sax.Element._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.sax.TextElementListener TextElementListener
		{
			set
			{
				setTextElementListener(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setTextElementListener(android.sax.TextElementListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.sax.Element.staticClass, "setTextElementListener", "(Landroid/sax/TextElementListener;)V", ref global::android.sax.Element._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.sax.StartElementListener StartElementListener
		{
			set
			{
				setStartElementListener(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setStartElementListener(android.sax.StartElementListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.sax.Element.staticClass, "setStartElementListener", "(Landroid/sax/StartElementListener;)V", ref global::android.sax.Element._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setEndElementListener(android.sax.EndElementListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.sax.Element.staticClass, "setEndElementListener", "(Landroid/sax/EndElementListener;)V", ref global::android.sax.Element._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void setEndTextElementListener(android.sax.EndTextElementListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.sax.Element.staticClass, "setEndTextElementListener", "(Landroid/sax/EndTextElementListener;)V", ref global::android.sax.Element._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
	}
}
