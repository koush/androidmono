namespace android.graphics.drawable
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class TransitionDrawable : android.graphics.drawable.LayerDrawable, android.graphics.drawable.Drawable.Callback
	{
		internal new static global::java.lang.Class staticClass;
		static TransitionDrawable()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.drawable.TransitionDrawable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.graphics.drawable.TransitionDrawable(@__env);
			}
		}
		protected TransitionDrawable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _draw3814;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.TransitionDrawable._draw3814, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.TransitionDrawable.staticClass, global::android.graphics.drawable.TransitionDrawable._draw3814, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startTransition3815;
		public virtual void startTransition(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.TransitionDrawable._startTransition3815, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.TransitionDrawable.staticClass, global::android.graphics.drawable.TransitionDrawable._startTransition3815, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _resetTransition3816;
		public virtual void resetTransition() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.TransitionDrawable._resetTransition3816);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.TransitionDrawable.staticClass, global::android.graphics.drawable.TransitionDrawable._resetTransition3816);
		}
		internal static global::net.sf.jni4net.jni.MethodId _reverseTransition3817;
		public virtual void reverseTransition(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.TransitionDrawable._reverseTransition3817, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.TransitionDrawable.staticClass, global::android.graphics.drawable.TransitionDrawable._reverseTransition3817, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCrossFadeEnabled3818;
		public virtual void setCrossFadeEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.TransitionDrawable._setCrossFadeEnabled3818, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.TransitionDrawable.staticClass, global::android.graphics.drawable.TransitionDrawable._setCrossFadeEnabled3818, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isCrossFadeEnabled3819;
		public virtual bool isCrossFadeEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.TransitionDrawable._isCrossFadeEnabled3819);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.TransitionDrawable.staticClass, global::android.graphics.drawable.TransitionDrawable._isCrossFadeEnabled3819);
		}
		internal static global::net.sf.jni4net.jni.MethodId _TransitionDrawable3820;
		public TransitionDrawable(android.graphics.drawable.Drawable[] arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.drawable.TransitionDrawable.staticClass, global::android.graphics.drawable.TransitionDrawable._TransitionDrawable3820, this, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.drawable.TransitionDrawable.staticClass = @__class;
			global::android.graphics.drawable.TransitionDrawable._draw3814 = @__env.GetMethodID(global::android.graphics.drawable.TransitionDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.TransitionDrawable._startTransition3815 = @__env.GetMethodID(global::android.graphics.drawable.TransitionDrawable.staticClass, "startTransition", "(I)V");
			global::android.graphics.drawable.TransitionDrawable._resetTransition3816 = @__env.GetMethodID(global::android.graphics.drawable.TransitionDrawable.staticClass, "resetTransition", "()V");
			global::android.graphics.drawable.TransitionDrawable._reverseTransition3817 = @__env.GetMethodID(global::android.graphics.drawable.TransitionDrawable.staticClass, "reverseTransition", "(I)V");
			global::android.graphics.drawable.TransitionDrawable._setCrossFadeEnabled3818 = @__env.GetMethodID(global::android.graphics.drawable.TransitionDrawable.staticClass, "setCrossFadeEnabled", "(Z)V");
			global::android.graphics.drawable.TransitionDrawable._isCrossFadeEnabled3819 = @__env.GetMethodID(global::android.graphics.drawable.TransitionDrawable.staticClass, "isCrossFadeEnabled", "()Z");
			global::android.graphics.drawable.TransitionDrawable._TransitionDrawable3820 = @__env.GetMethodID(global::android.graphics.drawable.TransitionDrawable.staticClass, "<init>", "([Landroid/graphics/drawable/Drawable;)V");
		}
	}
}
