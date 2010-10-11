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
		internal static global::MonoJavaBridge.MethodId _setText12333;
		public virtual void setText(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Toast._setText12333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._setText12333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setText(string arg0)
		{
			setText((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setText12334;
		public virtual void setText(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Toast._setText12334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._setText12334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cancel12335;
		public virtual void cancel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Toast._cancel12335);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._cancel12335);
		}
		internal static global::MonoJavaBridge.MethodId _setGravity12336;
		public virtual void setGravity(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Toast._setGravity12336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._setGravity12336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _show12337;
		public virtual void show() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Toast._show12337);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._show12337);
		}
		internal static global::MonoJavaBridge.MethodId _setView12338;
		public virtual void setView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Toast._setView12338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._setView12338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getView12339;
		public virtual global::android.view.View getView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.Toast._getView12339)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._getView12339)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _getGravity12340;
		public virtual int getGravity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Toast._getGravity12340);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._getGravity12340);
		}
		internal static global::MonoJavaBridge.MethodId _setDuration12341;
		public virtual void setDuration(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Toast._setDuration12341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._setDuration12341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDuration12342;
		public virtual int getDuration() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Toast._getDuration12342);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._getDuration12342);
		}
		internal static global::MonoJavaBridge.MethodId _setMargin12343;
		public virtual void setMargin(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Toast._setMargin12343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._setMargin12343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getHorizontalMargin12344;
		public virtual float getHorizontalMargin() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.Toast._getHorizontalMargin12344);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._getHorizontalMargin12344);
		}
		internal static global::MonoJavaBridge.MethodId _getVerticalMargin12345;
		public virtual float getVerticalMargin() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.Toast._getVerticalMargin12345);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._getVerticalMargin12345);
		}
		internal static global::MonoJavaBridge.MethodId _getXOffset12346;
		public virtual int getXOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Toast._getXOffset12346);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._getXOffset12346);
		}
		internal static global::MonoJavaBridge.MethodId _getYOffset12347;
		public virtual int getYOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Toast._getYOffset12347);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._getYOffset12347);
		}
		internal static global::MonoJavaBridge.MethodId _makeText12348;
		public static global::android.widget.Toast makeText(android.content.Context arg0, java.lang.CharSequence arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.widget.Toast.staticClass, global::android.widget.Toast._makeText12348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.widget.Toast;
		}
		internal static global::MonoJavaBridge.MethodId _makeText12349;
		public static global::android.widget.Toast makeText(android.content.Context arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.widget.Toast.staticClass, global::android.widget.Toast._makeText12349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.widget.Toast;
		}
		internal static global::MonoJavaBridge.MethodId _Toast12350;
		public Toast(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Toast.staticClass, global::android.widget.Toast._Toast12350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::android.widget.Toast._setText12333 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "setText", "(Ljava/lang/CharSequence;)V");
			global::android.widget.Toast._setText12334 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "setText", "(I)V");
			global::android.widget.Toast._cancel12335 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "cancel", "()V");
			global::android.widget.Toast._setGravity12336 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "setGravity", "(III)V");
			global::android.widget.Toast._show12337 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "show", "()V");
			global::android.widget.Toast._setView12338 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "setView", "(Landroid/view/View;)V");
			global::android.widget.Toast._getView12339 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "getView", "()Landroid/view/View;");
			global::android.widget.Toast._getGravity12340 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "getGravity", "()I");
			global::android.widget.Toast._setDuration12341 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "setDuration", "(I)V");
			global::android.widget.Toast._getDuration12342 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "getDuration", "()I");
			global::android.widget.Toast._setMargin12343 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "setMargin", "(FF)V");
			global::android.widget.Toast._getHorizontalMargin12344 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "getHorizontalMargin", "()F");
			global::android.widget.Toast._getVerticalMargin12345 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "getVerticalMargin", "()F");
			global::android.widget.Toast._getXOffset12346 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "getXOffset", "()I");
			global::android.widget.Toast._getYOffset12347 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "getYOffset", "()I");
			global::android.widget.Toast._makeText12348 = @__env.GetStaticMethodIDNoThrow(global::android.widget.Toast.staticClass, "makeText", "(Landroid/content/Context;Ljava/lang/CharSequence;I)Landroid/widget/Toast;");
			global::android.widget.Toast._makeText12349 = @__env.GetStaticMethodIDNoThrow(global::android.widget.Toast.staticClass, "makeText", "(Landroid/content/Context;II)Landroid/widget/Toast;");
			global::android.widget.Toast._Toast12350 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
