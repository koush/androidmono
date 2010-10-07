namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ViewFlipper : android.widget.ViewAnimator
	{
		internal new static global::java.lang.Class staticClass;
		static ViewFlipper()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.ViewFlipper), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.ViewFlipper(@__env);
			}
		}
		protected ViewFlipper(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _onAttachedToWindow12030;
		protected override void onAttachedToWindow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ViewFlipper._onAttachedToWindow12030);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._onAttachedToWindow12030);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow12031;
		protected override void onDetachedFromWindow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ViewFlipper._onDetachedFromWindow12031);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._onDetachedFromWindow12031);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onWindowVisibilityChanged12032;
		protected override void onWindowVisibilityChanged(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ViewFlipper._onWindowVisibilityChanged12032, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._onWindowVisibilityChanged12032, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFlipInterval12033;
		public virtual void setFlipInterval(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ViewFlipper._setFlipInterval12033, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._setFlipInterval12033, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startFlipping12034;
		public virtual void startFlipping() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ViewFlipper._startFlipping12034);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._startFlipping12034);
		}
		internal static global::net.sf.jni4net.jni.MethodId _stopFlipping12035;
		public virtual void stopFlipping() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ViewFlipper._stopFlipping12035);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._stopFlipping12035);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isFlipping12036;
		public virtual bool isFlipping() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ViewFlipper._isFlipping12036);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._isFlipping12036);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAutoStart12037;
		public virtual void setAutoStart(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ViewFlipper._setAutoStart12037, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._setAutoStart12037, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isAutoStart12038;
		public virtual bool isAutoStart() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ViewFlipper._isAutoStart12038);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._isAutoStart12038);
		}
		internal static global::net.sf.jni4net.jni.MethodId _ViewFlipper12039;
		public ViewFlipper(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._ViewFlipper12039, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ViewFlipper12040;
		public ViewFlipper(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ViewFlipper.staticClass, global::android.widget.ViewFlipper._ViewFlipper12040, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.ViewFlipper.staticClass = @__class;
			global::android.widget.ViewFlipper._onAttachedToWindow12030 = @__env.GetMethodID(global::android.widget.ViewFlipper.staticClass, "onAttachedToWindow", "()V");
			global::android.widget.ViewFlipper._onDetachedFromWindow12031 = @__env.GetMethodID(global::android.widget.ViewFlipper.staticClass, "onDetachedFromWindow", "()V");
			global::android.widget.ViewFlipper._onWindowVisibilityChanged12032 = @__env.GetMethodID(global::android.widget.ViewFlipper.staticClass, "onWindowVisibilityChanged", "(I)V");
			global::android.widget.ViewFlipper._setFlipInterval12033 = @__env.GetMethodID(global::android.widget.ViewFlipper.staticClass, "setFlipInterval", "(I)V");
			global::android.widget.ViewFlipper._startFlipping12034 = @__env.GetMethodID(global::android.widget.ViewFlipper.staticClass, "startFlipping", "()V");
			global::android.widget.ViewFlipper._stopFlipping12035 = @__env.GetMethodID(global::android.widget.ViewFlipper.staticClass, "stopFlipping", "()V");
			global::android.widget.ViewFlipper._isFlipping12036 = @__env.GetMethodID(global::android.widget.ViewFlipper.staticClass, "isFlipping", "()Z");
			global::android.widget.ViewFlipper._setAutoStart12037 = @__env.GetMethodID(global::android.widget.ViewFlipper.staticClass, "setAutoStart", "(Z)V");
			global::android.widget.ViewFlipper._isAutoStart12038 = @__env.GetMethodID(global::android.widget.ViewFlipper.staticClass, "isAutoStart", "()Z");
			global::android.widget.ViewFlipper._ViewFlipper12039 = @__env.GetMethodID(global::android.widget.ViewFlipper.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.ViewFlipper._ViewFlipper12040 = @__env.GetMethodID(global::android.widget.ViewFlipper.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
