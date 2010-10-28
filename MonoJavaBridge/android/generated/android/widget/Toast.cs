namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Toast : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Toast(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setText18183;
		public virtual void setText(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Toast._setText18183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._setText18183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setText(string arg0)
		{
			setText((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setText18184;
		public virtual void setText(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Toast._setText18184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._setText18184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cancel18185;
		public virtual void cancel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Toast._cancel18185);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._cancel18185);
		}
		internal static global::MonoJavaBridge.MethodId _setGravity18186;
		public virtual void setGravity(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Toast._setGravity18186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._setGravity18186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _show18187;
		public virtual void show()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Toast._show18187);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._show18187);
		}
		internal static global::MonoJavaBridge.MethodId _setView18188;
		public virtual void setView(android.view.View arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Toast._setView18188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._setView18188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getView18189;
		public virtual global::android.view.View getView()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.Toast._getView18189)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._getView18189)) as android.view.View;
		}
		public new int Gravity
		{
			get
			{
				return getGravity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGravity18190;
		public virtual int getGravity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Toast._getGravity18190);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._getGravity18190);
		}
		internal static global::MonoJavaBridge.MethodId _setDuration18191;
		public virtual void setDuration(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Toast._setDuration18191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._setDuration18191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDuration18192;
		public virtual int getDuration()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Toast._getDuration18192);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._getDuration18192);
		}
		internal static global::MonoJavaBridge.MethodId _setMargin18193;
		public virtual void setMargin(float arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Toast._setMargin18193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._setMargin18193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new float HorizontalMargin
		{
			get
			{
				return getHorizontalMargin();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHorizontalMargin18194;
		public virtual float getHorizontalMargin()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.Toast._getHorizontalMargin18194);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._getHorizontalMargin18194);
		}
		public new float VerticalMargin
		{
			get
			{
				return getVerticalMargin();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVerticalMargin18195;
		public virtual float getVerticalMargin()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.Toast._getVerticalMargin18195);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._getVerticalMargin18195);
		}
		public new int XOffset
		{
			get
			{
				return getXOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getXOffset18196;
		public virtual int getXOffset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Toast._getXOffset18196);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._getXOffset18196);
		}
		public new int YOffset
		{
			get
			{
				return getYOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getYOffset18197;
		public virtual int getYOffset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Toast._getYOffset18197);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Toast.staticClass, global::android.widget.Toast._getYOffset18197);
		}
		internal static global::MonoJavaBridge.MethodId _makeText18198;
		public static global::android.widget.Toast makeText(android.content.Context arg0, java.lang.CharSequence arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.widget.Toast.staticClass, global::android.widget.Toast._makeText18198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.widget.Toast;
		}
		public static android.widget.Toast makeText(android.content.Context arg0, string arg1, int arg2)
		{
			return makeText(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _makeText18199;
		public static global::android.widget.Toast makeText(android.content.Context arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.widget.Toast.staticClass, global::android.widget.Toast._makeText18199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.widget.Toast;
		}
		internal static global::MonoJavaBridge.MethodId _Toast18200;
		public Toast(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Toast.staticClass, global::android.widget.Toast._Toast18200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::android.widget.Toast._setText18183 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "setText", "(Ljava/lang/CharSequence;)V");
			global::android.widget.Toast._setText18184 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "setText", "(I)V");
			global::android.widget.Toast._cancel18185 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "cancel", "()V");
			global::android.widget.Toast._setGravity18186 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "setGravity", "(III)V");
			global::android.widget.Toast._show18187 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "show", "()V");
			global::android.widget.Toast._setView18188 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "setView", "(Landroid/view/View;)V");
			global::android.widget.Toast._getView18189 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "getView", "()Landroid/view/View;");
			global::android.widget.Toast._getGravity18190 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "getGravity", "()I");
			global::android.widget.Toast._setDuration18191 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "setDuration", "(I)V");
			global::android.widget.Toast._getDuration18192 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "getDuration", "()I");
			global::android.widget.Toast._setMargin18193 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "setMargin", "(FF)V");
			global::android.widget.Toast._getHorizontalMargin18194 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "getHorizontalMargin", "()F");
			global::android.widget.Toast._getVerticalMargin18195 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "getVerticalMargin", "()F");
			global::android.widget.Toast._getXOffset18196 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "getXOffset", "()I");
			global::android.widget.Toast._getYOffset18197 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "getYOffset", "()I");
			global::android.widget.Toast._makeText18198 = @__env.GetStaticMethodIDNoThrow(global::android.widget.Toast.staticClass, "makeText", "(Landroid/content/Context;Ljava/lang/CharSequence;I)Landroid/widget/Toast;");
			global::android.widget.Toast._makeText18199 = @__env.GetStaticMethodIDNoThrow(global::android.widget.Toast.staticClass, "makeText", "(Landroid/content/Context;II)Landroid/widget/Toast;");
			global::android.widget.Toast._Toast18200 = @__env.GetMethodIDNoThrow(global::android.widget.Toast.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
