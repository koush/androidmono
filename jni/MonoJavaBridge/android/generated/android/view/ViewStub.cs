namespace android.view
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class ViewStub : android.view.View
	{
		internal new static global::java.lang.Class staticClass;
		static ViewStub()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.ViewStub), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.view.ViewStub(@__env);
			}
		}
		internal ViewStub(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnInflateListener 
		{
			void onInflate(android.view.ViewStub arg0, android.view.View arg1);
		}

		public partial class OnInflateListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnInflateListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnInflateListener : java.lang.Object, OnInflateListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnInflateListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.ViewStub.__OnInflateListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.view.ViewStub.__OnInflateListener(@__env);
				}
			}
			internal __OnInflateListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onInflate8631;
			 void android.view.ViewStub.OnInflateListener.onInflate(android.view.ViewStub arg0, android.view.View arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.view.ViewStub.__OnInflateListener._onInflate8631, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewStub.__OnInflateListener.staticClass, global::android.view.ViewStub.__OnInflateListener._onInflate8631, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.view.ViewStub.__OnInflateListener.staticClass = @__class;
				global::android.view.ViewStub.__OnInflateListener._onInflate8631 = @__env.GetMethodID(global::android.view.ViewStub.__OnInflateListener.staticClass, "android.view.ViewStub.OnInflateListener.onInflate", "(Landroid/view/ViewStub;Landroid/view/View;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _inflate8632;
		public global::android.view.View inflate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewStub._inflate8632));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewStub.staticClass, global::android.view.ViewStub._inflate8632));
		}
		internal static global::net.sf.jni4net.jni.MethodId _draw8633;
		public sealed override void draw(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewStub._draw8633, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewStub.staticClass, global::android.view.ViewStub._draw8633, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setVisibility8634;
		public sealed override void setVisibility(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewStub._setVisibility8634, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewStub.staticClass, global::android.view.ViewStub._setVisibility8634, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLayoutResource8635;
		public void setLayoutResource(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewStub._setLayoutResource8635, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewStub.staticClass, global::android.view.ViewStub._setLayoutResource8635, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLayoutResource8636;
		public int getLayoutResource() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.ViewStub._getLayoutResource8636);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.ViewStub.staticClass, global::android.view.ViewStub._getLayoutResource8636);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInflatedId8637;
		public int getInflatedId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.ViewStub._getInflatedId8637);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.ViewStub.staticClass, global::android.view.ViewStub._getInflatedId8637);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setInflatedId8638;
		public void setInflatedId(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewStub._setInflatedId8638, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewStub.staticClass, global::android.view.ViewStub._setInflatedId8638, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnInflateListener8639;
		public void setOnInflateListener(android.view.ViewStub.OnInflateListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewStub._setOnInflateListener8639, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewStub.staticClass, global::android.view.ViewStub._setOnInflateListener8639, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ViewStub8640;
		public ViewStub(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.ViewStub.staticClass, global::android.view.ViewStub._ViewStub8640, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ViewStub8641;
		public ViewStub(android.content.Context arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.ViewStub.staticClass, global::android.view.ViewStub._ViewStub8641, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ViewStub8642;
		public ViewStub(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.ViewStub.staticClass, global::android.view.ViewStub._ViewStub8642, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ViewStub8643;
		public ViewStub(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.ViewStub.staticClass, global::android.view.ViewStub._ViewStub8643, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.ViewStub.staticClass = @__class;
			global::android.view.ViewStub._inflate8632 = @__env.GetMethodID(global::android.view.ViewStub.staticClass, "inflate", "()Landroid/view/View;");
			global::android.view.ViewStub._draw8633 = @__env.GetMethodID(global::android.view.ViewStub.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.view.ViewStub._setVisibility8634 = @__env.GetMethodID(global::android.view.ViewStub.staticClass, "setVisibility", "(I)V");
			global::android.view.ViewStub._setLayoutResource8635 = @__env.GetMethodID(global::android.view.ViewStub.staticClass, "setLayoutResource", "(I)V");
			global::android.view.ViewStub._getLayoutResource8636 = @__env.GetMethodID(global::android.view.ViewStub.staticClass, "getLayoutResource", "()I");
			global::android.view.ViewStub._getInflatedId8637 = @__env.GetMethodID(global::android.view.ViewStub.staticClass, "getInflatedId", "()I");
			global::android.view.ViewStub._setInflatedId8638 = @__env.GetMethodID(global::android.view.ViewStub.staticClass, "setInflatedId", "(I)V");
			global::android.view.ViewStub._setOnInflateListener8639 = @__env.GetMethodID(global::android.view.ViewStub.staticClass, "setOnInflateListener", "(Landroid/view/ViewStub$OnInflateListener;)V");
			global::android.view.ViewStub._ViewStub8640 = @__env.GetMethodID(global::android.view.ViewStub.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.view.ViewStub._ViewStub8641 = @__env.GetMethodID(global::android.view.ViewStub.staticClass, "<init>", "(Landroid/content/Context;I)V");
			global::android.view.ViewStub._ViewStub8642 = @__env.GetMethodID(global::android.view.ViewStub.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.view.ViewStub._ViewStub8643 = @__env.GetMethodID(global::android.view.ViewStub.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
