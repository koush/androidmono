namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RatingBar : android.widget.AbsSeekBar
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RatingBar()
		{
			InitJNI();
		}
		protected RatingBar(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.RatingBar.OnRatingBarChangeListener_))]
		public interface OnRatingBarChangeListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onRatingChanged(android.widget.RatingBar arg0, float arg1, bool arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.RatingBar.OnRatingBarChangeListener))]
		public sealed partial class OnRatingBarChangeListener_ : java.lang.Object, OnRatingBarChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnRatingBarChangeListener_()
			{
				InitJNI();
			}
			internal OnRatingBarChangeListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onRatingChanged11736;
			 void android.widget.RatingBar.OnRatingBarChangeListener.onRatingChanged(android.widget.RatingBar arg0, float arg1, bool arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RatingBar.OnRatingBarChangeListener_._onRatingChanged11736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RatingBar.OnRatingBarChangeListener_.staticClass, global::android.widget.RatingBar.OnRatingBarChangeListener_._onRatingChanged11736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.RatingBar.OnRatingBarChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RatingBar$OnRatingBarChangeListener"));
				global::android.widget.RatingBar.OnRatingBarChangeListener_._onRatingChanged11736 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.OnRatingBarChangeListener_.staticClass, "onRatingChanged", "(Landroid/widget/RatingBar;FZ)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _isIndicator11737;
		public virtual bool isIndicator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.RatingBar._isIndicator11737);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._isIndicator11737);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure11738;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RatingBar._onMeasure11738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._onMeasure11738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setMax11739;
		public override void setMax(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RatingBar._setMax11739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._setMax11739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnRatingBarChangeListener11740;
		public virtual void setOnRatingBarChangeListener(android.widget.RatingBar.OnRatingBarChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RatingBar._setOnRatingBarChangeListener11740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._setOnRatingBarChangeListener11740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOnRatingBarChangeListener11741;
		public virtual global::android.widget.RatingBar.OnRatingBarChangeListener getOnRatingBarChangeListener() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.RatingBar.OnRatingBarChangeListener>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.RatingBar._getOnRatingBarChangeListener11741)) as android.widget.RatingBar.OnRatingBarChangeListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.RatingBar.OnRatingBarChangeListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._getOnRatingBarChangeListener11741)) as android.widget.RatingBar.OnRatingBarChangeListener;
		}
		internal static global::MonoJavaBridge.MethodId _setIsIndicator11742;
		public virtual void setIsIndicator(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RatingBar._setIsIndicator11742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._setIsIndicator11742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNumStars11743;
		public virtual void setNumStars(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RatingBar._setNumStars11743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._setNumStars11743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNumStars11744;
		public virtual int getNumStars() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.RatingBar._getNumStars11744);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._getNumStars11744);
		}
		internal static global::MonoJavaBridge.MethodId _setRating11745;
		public virtual void setRating(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RatingBar._setRating11745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._setRating11745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getRating11746;
		public virtual float getRating() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.RatingBar._getRating11746);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._getRating11746);
		}
		internal static global::MonoJavaBridge.MethodId _setStepSize11747;
		public virtual void setStepSize(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RatingBar._setStepSize11747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._setStepSize11747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getStepSize11748;
		public virtual float getStepSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.RatingBar._getStepSize11748);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._getStepSize11748);
		}
		internal static global::MonoJavaBridge.MethodId _RatingBar11749;
		public RatingBar(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RatingBar.staticClass, global::android.widget.RatingBar._RatingBar11749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RatingBar11750;
		public RatingBar(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RatingBar.staticClass, global::android.widget.RatingBar._RatingBar11750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RatingBar11751;
		public RatingBar(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RatingBar.staticClass, global::android.widget.RatingBar._RatingBar11751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.RatingBar.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RatingBar"));
			global::android.widget.RatingBar._isIndicator11737 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "isIndicator", "()Z");
			global::android.widget.RatingBar._onMeasure11738 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "onMeasure", "(II)V");
			global::android.widget.RatingBar._setMax11739 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "setMax", "(I)V");
			global::android.widget.RatingBar._setOnRatingBarChangeListener11740 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "setOnRatingBarChangeListener", "(Landroid/widget/RatingBar$OnRatingBarChangeListener;)V");
			global::android.widget.RatingBar._getOnRatingBarChangeListener11741 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "getOnRatingBarChangeListener", "()Landroid/widget/RatingBar$OnRatingBarChangeListener;");
			global::android.widget.RatingBar._setIsIndicator11742 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "setIsIndicator", "(Z)V");
			global::android.widget.RatingBar._setNumStars11743 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "setNumStars", "(I)V");
			global::android.widget.RatingBar._getNumStars11744 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "getNumStars", "()I");
			global::android.widget.RatingBar._setRating11745 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "setRating", "(F)V");
			global::android.widget.RatingBar._getRating11746 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "getRating", "()F");
			global::android.widget.RatingBar._setStepSize11747 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "setStepSize", "(F)V");
			global::android.widget.RatingBar._getStepSize11748 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "getStepSize", "()F");
			global::android.widget.RatingBar._RatingBar11749 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.RatingBar._RatingBar11750 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.RatingBar._RatingBar11751 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
