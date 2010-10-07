namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class RatingBar : android.widget.AbsSeekBar
	{
		internal new static global::java.lang.Class staticClass;
		static RatingBar()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.RatingBar), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.RatingBar(@__env);
			}
		}
		protected RatingBar(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnRatingBarChangeListener 
		{
			void onRatingChanged(android.widget.RatingBar arg0, float arg1, bool arg2);
		}

		public partial class OnRatingBarChangeListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnRatingBarChangeListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnRatingBarChangeListener : java.lang.Object, OnRatingBarChangeListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnRatingBarChangeListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.RatingBar.__OnRatingBarChangeListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.widget.RatingBar.__OnRatingBarChangeListener(@__env);
				}
			}
			internal __OnRatingBarChangeListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onRatingChanged11357;
			 void android.widget.RatingBar.OnRatingBarChangeListener.onRatingChanged(android.widget.RatingBar arg0, float arg1, bool arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.widget.RatingBar.__OnRatingBarChangeListener._onRatingChanged11357, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.RatingBar.__OnRatingBarChangeListener.staticClass, global::android.widget.RatingBar.__OnRatingBarChangeListener._onRatingChanged11357, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.RatingBar.__OnRatingBarChangeListener.staticClass = @__class;
				global::android.widget.RatingBar.__OnRatingBarChangeListener._onRatingChanged11357 = @__env.GetMethodID(global::android.widget.RatingBar.__OnRatingBarChangeListener.staticClass, "android.widget.RatingBar.OnRatingBarChangeListener.onRatingChanged", "(Landroid/widget/RatingBar;FZ)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _isIndicator11358;
		public virtual bool isIndicator() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.RatingBar._isIndicator11358);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._isIndicator11358);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure11359;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RatingBar._onMeasure11359, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._onMeasure11359, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMax11360;
		public override void setMax(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RatingBar._setMax11360, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._setMax11360, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnRatingBarChangeListener11361;
		public virtual void setOnRatingBarChangeListener(android.widget.RatingBar.OnRatingBarChangeListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RatingBar._setOnRatingBarChangeListener11361, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._setOnRatingBarChangeListener11361, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOnRatingBarChangeListener11362;
		public virtual global::android.widget.RatingBar.OnRatingBarChangeListener getOnRatingBarChangeListener() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.RatingBar.OnRatingBarChangeListener>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.RatingBar._getOnRatingBarChangeListener11362));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.RatingBar.OnRatingBarChangeListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._getOnRatingBarChangeListener11362));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setIsIndicator11363;
		public virtual void setIsIndicator(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RatingBar._setIsIndicator11363, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._setIsIndicator11363, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setNumStars11364;
		public virtual void setNumStars(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RatingBar._setNumStars11364, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._setNumStars11364, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNumStars11365;
		public virtual int getNumStars() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.RatingBar._getNumStars11365);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._getNumStars11365);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setRating11366;
		public virtual void setRating(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RatingBar._setRating11366, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._setRating11366, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRating11367;
		public virtual float getRating() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.widget.RatingBar._getRating11367);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._getRating11367);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setStepSize11368;
		public virtual void setStepSize(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RatingBar._setStepSize11368, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._setStepSize11368, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStepSize11369;
		public virtual float getStepSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.widget.RatingBar._getStepSize11369);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._getStepSize11369);
		}
		internal static global::net.sf.jni4net.jni.MethodId _RatingBar11370;
		public RatingBar(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.RatingBar.staticClass, global::android.widget.RatingBar._RatingBar11370, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _RatingBar11371;
		public RatingBar(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.RatingBar.staticClass, global::android.widget.RatingBar._RatingBar11371, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _RatingBar11372;
		public RatingBar(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.RatingBar.staticClass, global::android.widget.RatingBar._RatingBar11372, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.RatingBar.staticClass = @__class;
			global::android.widget.RatingBar._isIndicator11358 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "isIndicator", "()Z");
			global::android.widget.RatingBar._onMeasure11359 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "onMeasure", "(II)V");
			global::android.widget.RatingBar._setMax11360 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "setMax", "(I)V");
			global::android.widget.RatingBar._setOnRatingBarChangeListener11361 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "setOnRatingBarChangeListener", "(Landroid/widget/RatingBar$OnRatingBarChangeListener;)V");
			global::android.widget.RatingBar._getOnRatingBarChangeListener11362 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "getOnRatingBarChangeListener", "()Landroid/widget/RatingBar$OnRatingBarChangeListener;");
			global::android.widget.RatingBar._setIsIndicator11363 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "setIsIndicator", "(Z)V");
			global::android.widget.RatingBar._setNumStars11364 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "setNumStars", "(I)V");
			global::android.widget.RatingBar._getNumStars11365 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "getNumStars", "()I");
			global::android.widget.RatingBar._setRating11366 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "setRating", "(F)V");
			global::android.widget.RatingBar._getRating11367 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "getRating", "()F");
			global::android.widget.RatingBar._setStepSize11368 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "setStepSize", "(F)V");
			global::android.widget.RatingBar._getStepSize11369 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "getStepSize", "()F");
			global::android.widget.RatingBar._RatingBar11370 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.RatingBar._RatingBar11371 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.RatingBar._RatingBar11372 = @__env.GetMethodID(global::android.widget.RatingBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
