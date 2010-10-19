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
			internal static global::MonoJavaBridge.MethodId _onInflate10192;
			 void android.view.ViewStub.OnInflateListener.onInflate(android.view.ViewStub arg0, android.view.View arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewStub.OnInflateListener_._onInflate10192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewStub.OnInflateListener_.staticClass, global::android.view.ViewStub.OnInflateListener_._onInflate10192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewStub.OnInflateListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewStub$OnInflateListener"));
				global::android.view.ViewStub.OnInflateListener_._onInflate10192 = @__env.GetMethodIDNoThrow(global::android.view.ViewStub.OnInflateListener_.staticClass, "onInflate", "(Landroid/view/ViewStub;Landroid/view/View;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _inflate10193;
		public global::android.view.View inflate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.ViewStub._inflate10193)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.ViewStub.staticClass, global::android.view.ViewStub._inflate10193)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _draw10194;
		public sealed override void draw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewStub._draw10194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewStub.staticClass, global::android.view.ViewStub._draw10194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVisibility10195;
		public sealed override void setVisibility(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewStub._setVisibility10195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewStub.staticClass, global::android.view.ViewStub._setVisibility10195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLayoutResource10196;
		public void setLayoutResource(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewStub._setLayoutResource10196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewStub.staticClass, global::android.view.ViewStub._setLayoutResource10196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getLayoutResource10197;
		public int getLayoutResource() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewStub._getLayoutResource10197);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewStub.staticClass, global::android.view.ViewStub._getLayoutResource10197);
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
		internal static global::MonoJavaBridge.MethodId _getInflatedId10198;
		public int getInflatedId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.ViewStub._getInflatedId10198);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.ViewStub.staticClass, global::android.view.ViewStub._getInflatedId10198);
		}
		internal static global::MonoJavaBridge.MethodId _setInflatedId10199;
		public void setInflatedId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewStub._setInflatedId10199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewStub.staticClass, global::android.view.ViewStub._setInflatedId10199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnInflateListener10200;
		public void setOnInflateListener(android.view.ViewStub.OnInflateListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ViewStub._setOnInflateListener10200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.ViewStub.staticClass, global::android.view.ViewStub._setOnInflateListener10200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ViewStub10201;
		public ViewStub(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewStub.staticClass, global::android.view.ViewStub._ViewStub10201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ViewStub10202;
		public ViewStub(android.content.Context arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewStub.staticClass, global::android.view.ViewStub._ViewStub10202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ViewStub10203;
		public ViewStub(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewStub.staticClass, global::android.view.ViewStub._ViewStub10203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ViewStub10204;
		public ViewStub(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewStub.staticClass, global::android.view.ViewStub._ViewStub10204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ViewStub.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewStub"));
			global::android.view.ViewStub._inflate10193 = @__env.GetMethodIDNoThrow(global::android.view.ViewStub.staticClass, "inflate", "()Landroid/view/View;");
			global::android.view.ViewStub._draw10194 = @__env.GetMethodIDNoThrow(global::android.view.ViewStub.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.view.ViewStub._setVisibility10195 = @__env.GetMethodIDNoThrow(global::android.view.ViewStub.staticClass, "setVisibility", "(I)V");
			global::android.view.ViewStub._setLayoutResource10196 = @__env.GetMethodIDNoThrow(global::android.view.ViewStub.staticClass, "setLayoutResource", "(I)V");
			global::android.view.ViewStub._getLayoutResource10197 = @__env.GetMethodIDNoThrow(global::android.view.ViewStub.staticClass, "getLayoutResource", "()I");
			global::android.view.ViewStub._getInflatedId10198 = @__env.GetMethodIDNoThrow(global::android.view.ViewStub.staticClass, "getInflatedId", "()I");
			global::android.view.ViewStub._setInflatedId10199 = @__env.GetMethodIDNoThrow(global::android.view.ViewStub.staticClass, "setInflatedId", "(I)V");
			global::android.view.ViewStub._setOnInflateListener10200 = @__env.GetMethodIDNoThrow(global::android.view.ViewStub.staticClass, "setOnInflateListener", "(Landroid/view/ViewStub$OnInflateListener;)V");
			global::android.view.ViewStub._ViewStub10201 = @__env.GetMethodIDNoThrow(global::android.view.ViewStub.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.view.ViewStub._ViewStub10202 = @__env.GetMethodIDNoThrow(global::android.view.ViewStub.staticClass, "<init>", "(Landroid/content/Context;I)V");
			global::android.view.ViewStub._ViewStub10203 = @__env.GetMethodIDNoThrow(global::android.view.ViewStub.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.view.ViewStub._ViewStub10204 = @__env.GetMethodIDNoThrow(global::android.view.ViewStub.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
