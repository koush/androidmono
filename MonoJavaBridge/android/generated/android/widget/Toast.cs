namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Toast : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Toast(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void setText(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Toast.staticClass, "setText", "(Ljava/lang/CharSequence;)V", ref global::android.widget.Toast._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setText(string arg0)
		{
			setText((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void setText(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Toast.staticClass, "setText", "(I)V", ref global::android.widget.Toast._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void cancel()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Toast.staticClass, "cancel", "()V", ref global::android.widget.Toast._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setGravity(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Toast.staticClass, "setGravity", "(III)V", ref global::android.widget.Toast._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void show()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Toast.staticClass, "show", "()V", ref global::android.widget.Toast._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setView(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Toast.staticClass, "setView", "(Landroid/view/View;)V", ref global::android.widget.Toast._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.view.View View
		{
			get
			{
				return getView();
			}
			set
			{
				setView(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::android.view.View getView()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.Toast.staticClass, "getView", "()Landroid/view/View;", ref global::android.widget.Toast._m6) as android.view.View;
		}
		public new int Gravity
		{
			get
			{
				return getGravity();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual int getGravity()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.Toast.staticClass, "getGravity", "()I", ref global::android.widget.Toast._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setDuration(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Toast.staticClass, "setDuration", "(I)V", ref global::android.widget.Toast._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Duration
		{
			get
			{
				return getDuration();
			}
			set
			{
				setDuration(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual int getDuration()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.Toast.staticClass, "getDuration", "()I", ref global::android.widget.Toast._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setMargin(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Toast.staticClass, "setMargin", "(FF)V", ref global::android.widget.Toast._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new float HorizontalMargin
		{
			get
			{
				return getHorizontalMargin();
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual float getHorizontalMargin()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.widget.Toast.staticClass, "getHorizontalMargin", "()F", ref global::android.widget.Toast._m11);
		}
		public new float VerticalMargin
		{
			get
			{
				return getVerticalMargin();
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual float getVerticalMargin()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.widget.Toast.staticClass, "getVerticalMargin", "()F", ref global::android.widget.Toast._m12);
		}
		public new int XOffset
		{
			get
			{
				return getXOffset();
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual int getXOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.Toast.staticClass, "getXOffset", "()I", ref global::android.widget.Toast._m13);
		}
		public new int YOffset
		{
			get
			{
				return getYOffset();
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual int getYOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.Toast.staticClass, "getYOffset", "()I", ref global::android.widget.Toast._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static global::android.widget.Toast makeText(android.content.Context arg0, java.lang.CharSequence arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.Toast._m15.native == global::System.IntPtr.Zero)
				global::android.widget.Toast._m15 = @__env.GetStaticMethodIDNoThrow(global::android.widget.Toast.staticClass, "makeText", "(Landroid/content/Context;Ljava/lang/CharSequence;I)Landroid/widget/Toast;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.widget.Toast.staticClass, global::android.widget.Toast._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.widget.Toast;
		}
		public static android.widget.Toast makeText(android.content.Context arg0, string arg1, int arg2)
		{
			return makeText(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public static global::android.widget.Toast makeText(android.content.Context arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.Toast._m16.native == global::System.IntPtr.Zero)
				global::android.widget.Toast._m16 = @__env.GetStaticMethodIDNoThrow(global::android.widget.Toast.staticClass, "makeText", "(Landroid/content/Context;II)Landroid/widget/Toast;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.widget.Toast.staticClass, global::android.widget.Toast._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.widget.Toast;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public Toast(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.Toast._m17.native == global::System.IntPtr.Zero)
				global::android.widget.Toast._m17 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Toast.staticClass, global::android.widget.Toast._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static int LENGTH_SHORT
		{
			get
			{
				return 0;
			}
		}
		public static int LENGTH_LONG
		{
			get
			{
				return 1;
			}
		}
		static Toast()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.Toast.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Toast"));
		}
	}
}
