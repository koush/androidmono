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
			internal static global::MonoJavaBridge.MethodId _onRatingChanged12282;
			 void android.widget.RatingBar.OnRatingBarChangeListener.onRatingChanged(android.widget.RatingBar arg0, float arg1, bool arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RatingBar.OnRatingBarChangeListener_._onRatingChanged12282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RatingBar.OnRatingBarChangeListener_.staticClass, global::android.widget.RatingBar.OnRatingBarChangeListener_._onRatingChanged12282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.RatingBar.OnRatingBarChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RatingBar$OnRatingBarChangeListener"));
				global::android.widget.RatingBar.OnRatingBarChangeListener_._onRatingChanged12282 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.OnRatingBarChangeListener_.staticClass, "onRatingChanged", "(Landroid/widget/RatingBar;FZ)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _isIndicator12283;
		public virtual bool isIndicator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.RatingBar._isIndicator12283);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._isIndicator12283);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure12284;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RatingBar._onMeasure12284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._onMeasure12284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setMax12285;
		public override void setMax(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RatingBar._setMax12285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._setMax12285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnRatingBarChangeListener12286;
		public virtual void setOnRatingBarChangeListener(android.widget.RatingBar.OnRatingBarChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RatingBar._setOnRatingBarChangeListener12286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._setOnRatingBarChangeListener12286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOnRatingBarChangeListener12287;
		public virtual global::android.widget.RatingBar.OnRatingBarChangeListener getOnRatingBarChangeListener() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.RatingBar.OnRatingBarChangeListener>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.RatingBar._getOnRatingBarChangeListener12287)) as android.widget.RatingBar.OnRatingBarChangeListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.RatingBar.OnRatingBarChangeListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._getOnRatingBarChangeListener12287)) as android.widget.RatingBar.OnRatingBarChangeListener;
		}
		internal static global::MonoJavaBridge.MethodId _setIsIndicator12288;
		public virtual void setIsIndicator(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RatingBar._setIsIndicator12288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._setIsIndicator12288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNumStars12289;
		public virtual void setNumStars(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RatingBar._setNumStars12289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._setNumStars12289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int NumStars
		{
			get
			{
				return getNumStars();
			}
			set
			{
				setNumStars(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNumStars12290;
		public virtual int getNumStars() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.RatingBar._getNumStars12290);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._getNumStars12290);
		}
		internal static global::MonoJavaBridge.MethodId _setRating12291;
		public virtual void setRating(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RatingBar._setRating12291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._setRating12291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float Rating
		{
			get
			{
				return getRating();
			}
			set
			{
				setRating(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRating12292;
		public virtual float getRating() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.RatingBar._getRating12292);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._getRating12292);
		}
		internal static global::MonoJavaBridge.MethodId _setStepSize12293;
		public virtual void setStepSize(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RatingBar._setStepSize12293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._setStepSize12293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float StepSize
		{
			get
			{
				return getStepSize();
			}
			set
			{
				setStepSize(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStepSize12294;
		public virtual float getStepSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.widget.RatingBar._getStepSize12294);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.widget.RatingBar.staticClass, global::android.widget.RatingBar._getStepSize12294);
		}
		internal static global::MonoJavaBridge.MethodId _RatingBar12295;
		public RatingBar(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RatingBar.staticClass, global::android.widget.RatingBar._RatingBar12295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RatingBar12296;
		public RatingBar(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RatingBar.staticClass, global::android.widget.RatingBar._RatingBar12296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RatingBar12297;
		public RatingBar(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RatingBar.staticClass, global::android.widget.RatingBar._RatingBar12297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.RatingBar.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RatingBar"));
			global::android.widget.RatingBar._isIndicator12283 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "isIndicator", "()Z");
			global::android.widget.RatingBar._onMeasure12284 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "onMeasure", "(II)V");
			global::android.widget.RatingBar._setMax12285 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "setMax", "(I)V");
			global::android.widget.RatingBar._setOnRatingBarChangeListener12286 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "setOnRatingBarChangeListener", "(Landroid/widget/RatingBar$OnRatingBarChangeListener;)V");
			global::android.widget.RatingBar._getOnRatingBarChangeListener12287 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "getOnRatingBarChangeListener", "()Landroid/widget/RatingBar$OnRatingBarChangeListener;");
			global::android.widget.RatingBar._setIsIndicator12288 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "setIsIndicator", "(Z)V");
			global::android.widget.RatingBar._setNumStars12289 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "setNumStars", "(I)V");
			global::android.widget.RatingBar._getNumStars12290 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "getNumStars", "()I");
			global::android.widget.RatingBar._setRating12291 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "setRating", "(F)V");
			global::android.widget.RatingBar._getRating12292 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "getRating", "()F");
			global::android.widget.RatingBar._setStepSize12293 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "setStepSize", "(F)V");
			global::android.widget.RatingBar._getStepSize12294 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "getStepSize", "()F");
			global::android.widget.RatingBar._RatingBar12295 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.RatingBar._RatingBar12296 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.RatingBar._RatingBar12297 = @__env.GetMethodIDNoThrow(global::android.widget.RatingBar.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
