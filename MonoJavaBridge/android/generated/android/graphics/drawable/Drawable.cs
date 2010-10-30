namespace android.graphics.drawable
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.graphics.drawable.Drawable_))]
	public abstract partial class Drawable : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Drawable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.graphics.drawable.Drawable.Callback_))]
		public partial interface Callback  : global::MonoJavaBridge.IJavaObject 
		{
			void invalidateDrawable(android.graphics.drawable.Drawable arg0);
			void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2);
			void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.graphics.drawable.Drawable.Callback))]
		internal sealed partial class Callback_ : java.lang.Object, Callback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Callback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _invalidateDrawable5917;
			void android.graphics.drawable.Drawable.Callback.invalidateDrawable(android.graphics.drawable.Drawable arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.Callback_._invalidateDrawable5917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _scheduleDrawable5918;
			void android.graphics.drawable.Drawable.Callback.scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.Callback_._scheduleDrawable5918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _unscheduleDrawable5919;
			void android.graphics.drawable.Drawable.Callback.unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.Callback_._unscheduleDrawable5919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static Callback_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.drawable.Drawable.Callback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/Drawable$Callback"));
				global::android.graphics.drawable.Drawable.Callback_._invalidateDrawable5917 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.Callback_.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
				global::android.graphics.drawable.Drawable.Callback_._scheduleDrawable5918 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.Callback_.staticClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V");
				global::android.graphics.drawable.Drawable.Callback_._unscheduleDrawable5919 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.Callback_.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass(typeof(global::android.graphics.drawable.Drawable.ConstantState_))]
		public abstract partial class ConstantState : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected ConstantState(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _getChangingConfigurations5920;
			public abstract int getChangingConfigurations();
			internal static global::MonoJavaBridge.MethodId _newDrawable5921;
			public abstract global::android.graphics.drawable.Drawable newDrawable();
			internal static global::MonoJavaBridge.MethodId _newDrawable5922;
			public virtual global::android.graphics.drawable.Drawable newDrawable(android.content.res.Resources arg0)
			{
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.Drawable.ConstantState.staticClass, global::android.graphics.drawable.Drawable.ConstantState._newDrawable5922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			}
			internal static global::MonoJavaBridge.MethodId _ConstantState5923;
			public ConstantState() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.Drawable.ConstantState.staticClass, global::android.graphics.drawable.Drawable.ConstantState._ConstantState5923);
				Init(@__env, handle);
			}
			static ConstantState()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.drawable.Drawable.ConstantState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/Drawable$ConstantState"));
				global::android.graphics.drawable.Drawable.ConstantState._getChangingConfigurations5920 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.ConstantState.staticClass, "getChangingConfigurations", "()I");
				global::android.graphics.drawable.Drawable.ConstantState._newDrawable5921 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.ConstantState.staticClass, "newDrawable", "()Landroid/graphics/drawable/Drawable;");
				global::android.graphics.drawable.Drawable.ConstantState._newDrawable5922 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.ConstantState.staticClass, "newDrawable", "(Landroid/content/res/Resources;)Landroid/graphics/drawable/Drawable;");
				global::android.graphics.drawable.Drawable.ConstantState._ConstantState5923 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.ConstantState.staticClass, "<init>", "()V");
			}
			internal static void InitJNI()
			{
			}
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.graphics.drawable.Drawable.ConstantState))]
		internal sealed partial class ConstantState_ : android.graphics.drawable.Drawable.ConstantState
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal ConstantState_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _getChangingConfigurations5924;
			public override int getChangingConfigurations()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.ConstantState_._getChangingConfigurations5924);
			}
			internal static global::MonoJavaBridge.MethodId _newDrawable5925;
			public override global::android.graphics.drawable.Drawable newDrawable()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.Drawable.ConstantState_._newDrawable5925)) as android.graphics.drawable.Drawable;
			}
			static ConstantState_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.drawable.Drawable.ConstantState_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/Drawable$ConstantState"));
				global::android.graphics.drawable.Drawable.ConstantState_._getChangingConfigurations5924 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.ConstantState_.staticClass, "getChangingConfigurations", "()I");
				global::android.graphics.drawable.Drawable.ConstantState_._newDrawable5925 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.ConstantState_.staticClass, "newDrawable", "()Landroid/graphics/drawable/Drawable;");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _getState5926;
		public virtual int[] getState()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getState5926)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _setState5927;
		public virtual bool setState(int[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setState5927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _inflate5928;
		public virtual void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._inflate5928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _draw5929;
		public abstract void draw(android.graphics.Canvas arg0);
		internal static global::MonoJavaBridge.MethodId _setBounds5930;
		public virtual void setBounds(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setBounds5930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setBounds5931;
		public virtual void setBounds(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setBounds5931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _copyBounds5932;
		public virtual void copyBounds(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._copyBounds5932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _copyBounds5933;
		public virtual global::android.graphics.Rect copyBounds()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Rect>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._copyBounds5933)) as android.graphics.Rect;
		}
		internal static global::MonoJavaBridge.MethodId _getBounds5934;
		public virtual global::android.graphics.Rect getBounds()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Rect>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getBounds5934)) as android.graphics.Rect;
		}
		internal static global::MonoJavaBridge.MethodId _setChangingConfigurations5935;
		public virtual void setChangingConfigurations(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setChangingConfigurations5935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChangingConfigurations5936;
		public virtual int getChangingConfigurations()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getChangingConfigurations5936);
		}
		internal static global::MonoJavaBridge.MethodId _setDither5937;
		public virtual void setDither(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setDither5937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFilterBitmap5938;
		public virtual void setFilterBitmap(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setFilterBitmap5938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCallback5939;
		public virtual void setCallback(android.graphics.drawable.Drawable.Callback arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setCallback5939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _invalidateSelf5940;
		public virtual void invalidateSelf()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._invalidateSelf5940);
		}
		internal static global::MonoJavaBridge.MethodId _scheduleSelf5941;
		public virtual void scheduleSelf(java.lang.Runnable arg0, long arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._scheduleSelf5941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void scheduleSelf(global::java.lang.RunnableDelegate arg0, long arg1)
		{
			scheduleSelf((global::java.lang.RunnableDelegateWrapper)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _unscheduleSelf5942;
		public virtual void unscheduleSelf(java.lang.Runnable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._unscheduleSelf5942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void unscheduleSelf(global::java.lang.RunnableDelegate arg0)
		{
			unscheduleSelf((global::java.lang.RunnableDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setAlpha5943;
		public abstract void setAlpha(int arg0);
		internal static global::MonoJavaBridge.MethodId _setColorFilter5944;
		public abstract void setColorFilter(android.graphics.ColorFilter arg0);
		internal static global::MonoJavaBridge.MethodId _setColorFilter5945;
		public virtual void setColorFilter(int arg0, android.graphics.PorterDuff.Mode arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setColorFilter5945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clearColorFilter5946;
		public virtual void clearColorFilter()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._clearColorFilter5946);
		}
		internal static global::MonoJavaBridge.MethodId _isStateful5947;
		public virtual bool isStateful()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._isStateful5947);
		}
		internal static global::MonoJavaBridge.MethodId _getCurrent5948;
		public virtual global::android.graphics.drawable.Drawable getCurrent()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getCurrent5948)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _setLevel5949;
		public virtual bool setLevel(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setLevel5949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLevel5950;
		public virtual int getLevel()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getLevel5950);
		}
		internal static global::MonoJavaBridge.MethodId _setVisible5951;
		public virtual bool setVisible(bool arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._setVisible5951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isVisible5952;
		public virtual bool isVisible()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._isVisible5952);
		}
		internal static global::MonoJavaBridge.MethodId _getOpacity5953;
		public abstract int getOpacity();
		internal static global::MonoJavaBridge.MethodId _resolveOpacity5954;
		public static int resolveOpacity(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._resolveOpacity5954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getTransparentRegion5955;
		public virtual global::android.graphics.Region getTransparentRegion()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getTransparentRegion5955)) as android.graphics.Region;
		}
		internal static global::MonoJavaBridge.MethodId _onStateChange5956;
		protected virtual bool onStateChange(int[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._onStateChange5956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLevelChange5957;
		protected virtual bool onLevelChange(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._onLevelChange5957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onBoundsChange5958;
		protected virtual void onBoundsChange(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._onBoundsChange5958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicWidth5959;
		public virtual int getIntrinsicWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getIntrinsicWidth5959);
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicHeight5960;
		public virtual int getIntrinsicHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getIntrinsicHeight5960);
		}
		internal static global::MonoJavaBridge.MethodId _getMinimumWidth5961;
		public virtual int getMinimumWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getMinimumWidth5961);
		}
		internal static global::MonoJavaBridge.MethodId _getMinimumHeight5962;
		public virtual int getMinimumHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getMinimumHeight5962);
		}
		internal static global::MonoJavaBridge.MethodId _getPadding5963;
		public virtual bool getPadding(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getPadding5963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _mutate5964;
		public virtual global::android.graphics.drawable.Drawable mutate()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._mutate5964)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _createFromStream5965;
		public static global::android.graphics.drawable.Drawable createFromStream(java.io.InputStream arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._createFromStream5965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _createFromResourceStream5966;
		public static global::android.graphics.drawable.Drawable createFromResourceStream(android.content.res.Resources arg0, android.util.TypedValue arg1, java.io.InputStream arg2, java.lang.String arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._createFromResourceStream5966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _createFromResourceStream5967;
		public static global::android.graphics.drawable.Drawable createFromResourceStream(android.content.res.Resources arg0, android.util.TypedValue arg1, java.io.InputStream arg2, java.lang.String arg3, android.graphics.BitmapFactory.Options arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._createFromResourceStream5967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _createFromXml5968;
		public static global::android.graphics.drawable.Drawable createFromXml(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._createFromXml5968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _createFromXmlInner5969;
		public static global::android.graphics.drawable.Drawable createFromXmlInner(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._createFromXmlInner5969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _createFromPath5970;
		public static global::android.graphics.drawable.Drawable createFromPath(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._createFromPath5970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getConstantState5971;
		public virtual global::android.graphics.drawable.Drawable.ConstantState getConstantState()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._getConstantState5971)) as android.graphics.drawable.Drawable.ConstantState;
		}
		internal static global::MonoJavaBridge.MethodId _Drawable5972;
		public Drawable() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.Drawable.staticClass, global::android.graphics.drawable.Drawable._Drawable5972);
			Init(@__env, handle);
		}
		static Drawable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.Drawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/Drawable"));
			global::android.graphics.drawable.Drawable._getState5926 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "getState", "()[I");
			global::android.graphics.drawable.Drawable._setState5927 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "setState", "([I)Z");
			global::android.graphics.drawable.Drawable._inflate5928 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V");
			global::android.graphics.drawable.Drawable._draw5929 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.Drawable._setBounds5930 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "setBounds", "(IIII)V");
			global::android.graphics.drawable.Drawable._setBounds5931 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "setBounds", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.Drawable._copyBounds5932 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "copyBounds", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.Drawable._copyBounds5933 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "copyBounds", "()Landroid/graphics/Rect;");
			global::android.graphics.drawable.Drawable._getBounds5934 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "getBounds", "()Landroid/graphics/Rect;");
			global::android.graphics.drawable.Drawable._setChangingConfigurations5935 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "setChangingConfigurations", "(I)V");
			global::android.graphics.drawable.Drawable._getChangingConfigurations5936 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "getChangingConfigurations", "()I");
			global::android.graphics.drawable.Drawable._setDither5937 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "setDither", "(Z)V");
			global::android.graphics.drawable.Drawable._setFilterBitmap5938 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "setFilterBitmap", "(Z)V");
			global::android.graphics.drawable.Drawable._setCallback5939 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "setCallback", "(Landroid/graphics/drawable/Drawable$Callback;)V");
			global::android.graphics.drawable.Drawable._invalidateSelf5940 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "invalidateSelf", "()V");
			global::android.graphics.drawable.Drawable._scheduleSelf5941 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "scheduleSelf", "(Ljava/lang/Runnable;J)V");
			global::android.graphics.drawable.Drawable._unscheduleSelf5942 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "unscheduleSelf", "(Ljava/lang/Runnable;)V");
			global::android.graphics.drawable.Drawable._setAlpha5943 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "setAlpha", "(I)V");
			global::android.graphics.drawable.Drawable._setColorFilter5944 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.graphics.drawable.Drawable._setColorFilter5945 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "setColorFilter", "(ILandroid/graphics/PorterDuff$Mode;)V");
			global::android.graphics.drawable.Drawable._clearColorFilter5946 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "clearColorFilter", "()V");
			global::android.graphics.drawable.Drawable._isStateful5947 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "isStateful", "()Z");
			global::android.graphics.drawable.Drawable._getCurrent5948 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "getCurrent", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.Drawable._setLevel5949 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "setLevel", "(I)Z");
			global::android.graphics.drawable.Drawable._getLevel5950 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "getLevel", "()I");
			global::android.graphics.drawable.Drawable._setVisible5951 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "setVisible", "(ZZ)Z");
			global::android.graphics.drawable.Drawable._isVisible5952 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "isVisible", "()Z");
			global::android.graphics.drawable.Drawable._getOpacity5953 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "getOpacity", "()I");
			global::android.graphics.drawable.Drawable._resolveOpacity5954 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "resolveOpacity", "(II)I");
			global::android.graphics.drawable.Drawable._getTransparentRegion5955 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "getTransparentRegion", "()Landroid/graphics/Region;");
			global::android.graphics.drawable.Drawable._onStateChange5956 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "onStateChange", "([I)Z");
			global::android.graphics.drawable.Drawable._onLevelChange5957 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "onLevelChange", "(I)Z");
			global::android.graphics.drawable.Drawable._onBoundsChange5958 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.Drawable._getIntrinsicWidth5959 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "getIntrinsicWidth", "()I");
			global::android.graphics.drawable.Drawable._getIntrinsicHeight5960 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "getIntrinsicHeight", "()I");
			global::android.graphics.drawable.Drawable._getMinimumWidth5961 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "getMinimumWidth", "()I");
			global::android.graphics.drawable.Drawable._getMinimumHeight5962 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "getMinimumHeight", "()I");
			global::android.graphics.drawable.Drawable._getPadding5963 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.drawable.Drawable._mutate5964 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.Drawable._createFromStream5965 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "createFromStream", "(Ljava/io/InputStream;Ljava/lang/String;)Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.Drawable._createFromResourceStream5966 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "createFromResourceStream", "(Landroid/content/res/Resources;Landroid/util/TypedValue;Ljava/io/InputStream;Ljava/lang/String;)Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.Drawable._createFromResourceStream5967 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "createFromResourceStream", "(Landroid/content/res/Resources;Landroid/util/TypedValue;Ljava/io/InputStream;Ljava/lang/String;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.Drawable._createFromXml5968 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "createFromXml", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;)Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.Drawable._createFromXmlInner5969 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "createFromXmlInner", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.Drawable._createFromPath5970 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "createFromPath", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.Drawable._getConstantState5971 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;");
			global::android.graphics.drawable.Drawable._Drawable5972 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.graphics.drawable.Drawable))]
	internal sealed partial class Drawable_ : android.graphics.drawable.Drawable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Drawable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _draw5973;
		public override void draw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable_._draw5973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAlpha5974;
		public override void setAlpha(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable_._setAlpha5974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setColorFilter5975;
		public override void setColorFilter(android.graphics.ColorFilter arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.Drawable_._setColorFilter5975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getOpacity5976;
		public override int getOpacity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.Drawable_._getOpacity5976);
		}
		static Drawable_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.Drawable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/Drawable"));
			global::android.graphics.drawable.Drawable_._draw5973 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable_.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.Drawable_._setAlpha5974 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable_.staticClass, "setAlpha", "(I)V");
			global::android.graphics.drawable.Drawable_._setColorFilter5975 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable_.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.graphics.drawable.Drawable_._getOpacity5976 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.Drawable_.staticClass, "getOpacity", "()I");
		}
		internal static void InitJNI()
		{
		}
	}
}
