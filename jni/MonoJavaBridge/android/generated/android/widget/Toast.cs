namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Toast : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Toast()
		{
			InitJNI();
		}
		protected Toast(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setText18066;
		public virtual void setText(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Toast._setText18066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._setText18066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setText(string arg0)
		{
			setText((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setText18067;
		public virtual void setText(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Toast._setText18067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._setText18067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cancel18068;
		public virtual void cancel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Toast._cancel18068);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._cancel18068);
		}
		internal static global::MonoJavaBridge.MethodId _setGravity18069;
		public virtual void setGravity(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Toast._setGravity18069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._setGravity18069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _show18070;
		public virtual void show() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Toast._show18070);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._show18070);
		}
		internal static global::MonoJavaBridge.MethodId _setView18071;
		public virtual void setView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Toast._setView18071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._setView18071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getView18072;
		public virtual global::android.view.View getView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.Toast._getView18072)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._getView18072)) as android.view.View;
		}
		public new int Gravity
		{
			get
			{
				return getGravity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGravity18073;
		public virtual int getGravity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Toast._getGravity18073);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._getGravity18073);
		}
		internal static global::MonoJavaBridge.MethodId _setDuration18074;
		public virtual void setDuration(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Toast._setDuration18074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._setDuration18074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDuration18075;
		public virtual int getDuration() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Toast._getDuration18075);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._getDuration18075);
		}
		internal static global::MonoJavaBridge.MethodId _setMargin18076;
		public virtual void setMargin(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Toast._setMargin18076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._setMargin18076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new float HorizontalMargin
		{
			get
			{
				return getHorizontalMargin();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHorizontalMargin18077;
		public virtual float getHorizontalMargin() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.Toast._getHorizontalMargin18077);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._getHorizontalMargin18077);
		}
		public new float VerticalMargin
		{
			get
			{
				return getVerticalMargin();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVerticalMargin18078;
		public virtual float getVerticalMargin() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.Toast._getVerticalMargin18078);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._getVerticalMargin18078);
		}
		public new int XOffset
		{
			get
			{
				return getXOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getXOffset18079;
		public virtual int getXOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Toast._getXOffset18079);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._getXOffset18079);
		}
		public new int YOffset
		{
			get
			{
				return getYOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getYOffset18080;
		public virtual int getYOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Toast._getYOffset18080);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._getYOffset18080);
		}
		internal static global::MonoJavaBridge.MethodId _makeText18081;
		public static global::android.widget.Toast makeText(android.content.Context arg0, java.lang.CharSequence arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.widget.Toast.staticClass, global::android.widget.Toast._makeText18081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.widget.Toast;
		}
		internal static global::MonoJavaBridge.MethodId _makeText18082;
		public static global::android.widget.Toast makeText(android.content.Context arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.widget.Toast.staticClass, global::android.widget.Toast._makeText18082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.widget.Toast;
		}
		internal static global::MonoJavaBridge.MethodId _Toast18083;
		public Toast(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Toast.staticClass, global::android.widget.Toast._Toast18083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.Toast.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Toast"));
			global::android.widget.Toast._setText18066 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "setText", "(Ljava/lang/CharSequence;)V");
			global::android.widget.Toast._setText18067 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "setText", "(I)V");
			global::android.widget.Toast._cancel18068 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "cancel", "()V");
			global::android.widget.Toast._setGravity18069 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "setGravity", "(III)V");
			global::android.widget.Toast._show18070 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "show", "()V");
			global::android.widget.Toast._setView18071 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "setView", "(Landroid/view/View;)V");
			global::android.widget.Toast._getView18072 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "getView", "()Landroid/view/View;");
			global::android.widget.Toast._getGravity18073 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "getGravity", "()I");
			global::android.widget.Toast._setDuration18074 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "setDuration", "(I)V");
			global::android.widget.Toast._getDuration18075 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "getDuration", "()I");
			global::android.widget.Toast._setMargin18076 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "setMargin", "(FF)V");
			global::android.widget.Toast._getHorizontalMargin18077 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "getHorizontalMargin", "()F");
			global::android.widget.Toast._getVerticalMargin18078 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "getVerticalMargin", "()F");
			global::android.widget.Toast._getXOffset18079 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "getXOffset", "()I");
			global::android.widget.Toast._getYOffset18080 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "getYOffset", "()I");
			global::android.widget.Toast._makeText18081 = @__env.GetStaticMethodIDNoThrow(global::android.widget.Toast.staticClass, "makeText", "(Landroid/content/Context;Ljava/lang/CharSequence;I)Landroid/widget/Toast;");
			global::android.widget.Toast._makeText18082 = @__env.GetStaticMethodIDNoThrow(global::android.widget.Toast.staticClass, "makeText", "(Landroid/content/Context;II)Landroid/widget/Toast;");
			global::android.widget.Toast._Toast18083 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
