namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class ViewStub : android.view.View
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ViewStub()
		{
			InitJNI();
		}
		internal ViewStub(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.ViewStub.OnInflateListener_))]
		public interface OnInflateListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onInflate(android.view.ViewStub arg0, android.view.View arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.ViewStub.OnInflateListener))]
		public sealed partial class OnInflateListener_ : java.lang.Object, OnInflateListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnInflateListener_()
			{
				InitJNI();
			}
			internal OnInflateListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onInflate15132;
			 void android.view.ViewStub.OnInflateListener.onInflate(android.view.ViewStub arg0, android.view.View arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewStub.OnInflateListener_._onInflate15132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewStub.OnInflateListener_.staticClass, global::android.view.ViewStub.OnInflateListener_._onInflate15132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewStub.OnInflateListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewStub$OnInflateListener"));
				global::android.view.ViewStub.OnInflateListener_._onInflate15132 = @__env.GetMethodIDNoThrow(global::android.view.ViewStub.OnInflateListener_.staticClass, "onInflate", "(Landroid/view/ViewStub;Landroid/view/View;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _inflate15133;
		public global::android.view.View inflate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewStub._inflate15133)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewStub.staticClass, global::android.view.ViewStub._inflate15133)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _draw15134;
		public sealed override void draw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewStub._draw15134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewStub.staticClass, global::android.view.ViewStub._draw15134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVisibility15135;
		public sealed override void setVisibility(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewStub._setVisibility15135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewStub.staticClass, global::android.view.ViewStub._setVisibility15135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLayoutResource15136;
		public void setLayoutResource(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewStub._setLayoutResource15136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewStub.staticClass, global::android.view.ViewStub._setLayoutResource15136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int LayoutResource
		{
			get
			{
				return getLayoutResource();
			}
			set
			{
				setLayoutResource(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLayoutResource15137;
		public int getLayoutResource() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewStub._getLayoutResource15137);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewStub.staticClass, global::android.view.ViewStub._getLayoutResource15137);
		}
		public new int InflatedId
		{
			get
			{
				return getInflatedId();
			}
			set
			{
				setInflatedId(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInflatedId15138;
		public int getInflatedId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewStub._getInflatedId15138);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewStub.staticClass, global::android.view.ViewStub._getInflatedId15138);
		}
		internal static global::MonoJavaBridge.MethodId _setInflatedId15139;
		public void setInflatedId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewStub._setInflatedId15139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewStub.staticClass, global::android.view.ViewStub._setInflatedId15139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnInflateListener15140;
		public void setOnInflateListener(android.view.ViewStub.OnInflateListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewStub._setOnInflateListener15140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewStub.staticClass, global::android.view.ViewStub._setOnInflateListener15140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ViewStub15141;
		public ViewStub(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewStub.staticClass, global::android.view.ViewStub._ViewStub15141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ViewStub15142;
		public ViewStub(android.content.Context arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewStub.staticClass, global::android.view.ViewStub._ViewStub15142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ViewStub15143;
		public ViewStub(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewStub.staticClass, global::android.view.ViewStub._ViewStub15143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ViewStub15144;
		public ViewStub(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewStub.staticClass, global::android.view.ViewStub._ViewStub15144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ViewStub.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewStub"));
			global::android.view.ViewStub._inflate15133 = @__env.GetMethodIDNoThrow(global::android.view.ViewStub.staticClass, "inflate", "()Landroid/view/View;");
			global::android.view.ViewStub._draw15134 = @__env.GetMethodIDNoThrow(global::android.view.ViewStub.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.view.ViewStub._setVisibility15135 = @__env.GetMethodIDNoThrow(global::android.view.ViewStub.staticClass, "setVisibility", "(I)V");
			global::android.view.ViewStub._setLayoutResource15136 = @__env.GetMethodIDNoThrow(global::android.view.ViewStub.staticClass, "setLayoutResource", "(I)V");
			global::android.view.ViewStub._getLayoutResource15137 = @__env.GetMethodIDNoThrow(global::android.view.ViewStub.staticClass, "getLayoutResource", "()I");
			global::android.view.ViewStub._getInflatedId15138 = @__env.GetMethodIDNoThrow(global::android.view.ViewStub.staticClass, "getInflatedId", "()I");
			global::android.view.ViewStub._setInflatedId15139 = @__env.GetMethodIDNoThrow(global::android.view.ViewStub.staticClass, "setInflatedId", "(I)V");
			global::android.view.ViewStub._setOnInflateListener15140 = @__env.GetMethodIDNoThrow(global::android.view.ViewStub.staticClass, "setOnInflateListener", "(Landroid/view/ViewStub$OnInflateListener;)V");
			global::android.view.ViewStub._ViewStub15141 = @__env.GetMethodIDNoThrow(global::android.view.ViewStub.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.view.ViewStub._ViewStub15142 = @__env.GetMethodIDNoThrow(global::android.view.ViewStub.staticClass, "<init>", "(Landroid/content/Context;I)V");
			global::android.view.ViewStub._ViewStub15143 = @__env.GetMethodIDNoThrow(global::android.view.ViewStub.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.view.ViewStub._ViewStub15144 = @__env.GetMethodIDNoThrow(global::android.view.ViewStub.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
