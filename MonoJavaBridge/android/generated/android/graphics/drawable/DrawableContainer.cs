namespace android.graphics.drawable
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DrawableContainer : android.graphics.drawable.Drawable, android.graphics.drawable.Drawable.Callback
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DrawableContainer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass(typeof(global::android.graphics.drawable.DrawableContainer.DrawableContainerState_))]
		public abstract partial class DrawableContainerState : android.graphics.drawable.Drawable.ConstantState
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected DrawableContainerState(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _getChangingConfigurations5977;
			public override int getChangingConfigurations()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChangingConfigurations5977);
			}
			internal static global::MonoJavaBridge.MethodId _isStateful5978;
			public virtual bool isStateful()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._isStateful5978);
			}
			internal static global::MonoJavaBridge.MethodId _getOpacity5979;
			public virtual int getOpacity()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getOpacity5979);
			}
			internal static global::MonoJavaBridge.MethodId _getChildCount5980;
			public virtual int getChildCount()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChildCount5980);
			}
			internal static global::MonoJavaBridge.MethodId _addChild5981;
			public virtual int addChild(android.graphics.drawable.Drawable arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._addChild5981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _getChildren5982;
			public virtual global::android.graphics.drawable.Drawable[] getChildren()
			{
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.drawable.Drawable>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChildren5982)) as android.graphics.drawable.Drawable[];
			}
			internal static global::MonoJavaBridge.MethodId _setVariablePadding5983;
			public virtual void setVariablePadding(bool arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._setVariablePadding5983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _getConstantPadding5984;
			public virtual global::android.graphics.Rect getConstantPadding()
			{
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Rect>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantPadding5984)) as android.graphics.Rect;
			}
			internal static global::MonoJavaBridge.MethodId _setConstantSize5985;
			public virtual void setConstantSize(bool arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._setConstantSize5985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _isConstantSize5986;
			public virtual bool isConstantSize()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._isConstantSize5986);
			}
			internal static global::MonoJavaBridge.MethodId _getConstantWidth5987;
			public virtual int getConstantWidth()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantWidth5987);
			}
			internal static global::MonoJavaBridge.MethodId _getConstantHeight5988;
			public virtual int getConstantHeight()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantHeight5988);
			}
			internal static global::MonoJavaBridge.MethodId _getConstantMinimumWidth5989;
			public virtual int getConstantMinimumWidth()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantMinimumWidth5989);
			}
			internal static global::MonoJavaBridge.MethodId _getConstantMinimumHeight5990;
			public virtual int getConstantMinimumHeight()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantMinimumHeight5990);
			}
			internal static global::MonoJavaBridge.MethodId _growArray5991;
			public virtual void growArray(int arg0, int arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._growArray5991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _canConstantState5992;
			public virtual bool canConstantState()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._canConstantState5992);
			}
			static DrawableContainerState()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/DrawableContainer$DrawableContainerState"));
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChangingConfigurations5977 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getChangingConfigurations", "()I");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._isStateful5978 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "isStateful", "()Z");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getOpacity5979 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getOpacity", "()I");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChildCount5980 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getChildCount", "()I");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._addChild5981 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "addChild", "(Landroid/graphics/drawable/Drawable;)I");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChildren5982 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getChildren", "()[Landroid/graphics/drawable/Drawable;");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._setVariablePadding5983 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "setVariablePadding", "(Z)V");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantPadding5984 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getConstantPadding", "()Landroid/graphics/Rect;");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._setConstantSize5985 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "setConstantSize", "(Z)V");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._isConstantSize5986 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "isConstantSize", "()Z");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantWidth5987 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getConstantWidth", "()I");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantHeight5988 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getConstantHeight", "()I");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantMinimumWidth5989 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getConstantMinimumWidth", "()I");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantMinimumHeight5990 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getConstantMinimumHeight", "()I");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._growArray5991 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "growArray", "(II)V");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._canConstantState5992 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "canConstantState", "()Z");
			}
			internal static void InitJNI()
			{
			}
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.graphics.drawable.DrawableContainer.DrawableContainerState))]
		internal sealed partial class DrawableContainerState_ : android.graphics.drawable.DrawableContainer.DrawableContainerState
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal DrawableContainerState_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _newDrawable5993;
			public override global::android.graphics.drawable.Drawable newDrawable()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState_._newDrawable5993)) as android.graphics.drawable.Drawable;
			}
			static DrawableContainerState_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/DrawableContainer$DrawableContainerState"));
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState_._newDrawable5993 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState_.staticClass, "newDrawable", "()Landroid/graphics/drawable/Drawable;");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _draw5994;
		public override void draw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._draw5994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ChangingConfigurations
		{
			get
			{
				return getChangingConfigurations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChangingConfigurations5995;
		public override int getChangingConfigurations()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getChangingConfigurations5995);
		}
		public new bool Dither
		{
			set
			{
				setDither(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setDither5996;
		public override void setDither(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._setDither5996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Alpha
		{
			set
			{
				setAlpha(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setAlpha5997;
		public override void setAlpha(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._setAlpha5997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.ColorFilter ColorFilter
		{
			set
			{
				setColorFilter(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setColorFilter5998;
		public override void setColorFilter(android.graphics.ColorFilter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._setColorFilter5998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isStateful5999;
		public override bool isStateful()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._isStateful5999);
		}
		public new global::android.graphics.drawable.Drawable Current
		{
			get
			{
				return getCurrent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrent6000;
		public override global::android.graphics.drawable.Drawable getCurrent()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getCurrent6000)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _setVisible6001;
		public override bool setVisible(bool arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._setVisible6001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int Opacity
		{
			get
			{
				return getOpacity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOpacity6002;
		public override int getOpacity()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getOpacity6002);
		}
		internal static global::MonoJavaBridge.MethodId _onStateChange6003;
		protected override bool onStateChange(int[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._onStateChange6003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLevelChange6004;
		protected override bool onLevelChange(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._onLevelChange6004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onBoundsChange6005;
		protected override void onBoundsChange(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._onBoundsChange6005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int IntrinsicWidth
		{
			get
			{
				return getIntrinsicWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicWidth6006;
		public override int getIntrinsicWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getIntrinsicWidth6006);
		}
		public new int IntrinsicHeight
		{
			get
			{
				return getIntrinsicHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicHeight6007;
		public override int getIntrinsicHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getIntrinsicHeight6007);
		}
		public new int MinimumWidth
		{
			get
			{
				return getMinimumWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMinimumWidth6008;
		public override int getMinimumWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getMinimumWidth6008);
		}
		public new int MinimumHeight
		{
			get
			{
				return getMinimumHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMinimumHeight6009;
		public override int getMinimumHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getMinimumHeight6009);
		}
		internal static global::MonoJavaBridge.MethodId _getPadding6010;
		public override bool getPadding(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getPadding6010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _mutate6011;
		public override global::android.graphics.drawable.Drawable mutate()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._mutate6011)) as android.graphics.drawable.Drawable;
		}
		public new global::android.graphics.drawable.Drawable.ConstantState ConstantState
		{
			get
			{
				return getConstantState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConstantState6012;
		public override global::android.graphics.drawable.Drawable.ConstantState getConstantState()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getConstantState6012)) as android.graphics.drawable.Drawable.ConstantState;
		}
		internal static global::MonoJavaBridge.MethodId _invalidateDrawable6013;
		public virtual void invalidateDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._invalidateDrawable6013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _scheduleDrawable6014;
		public virtual void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._scheduleDrawable6014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public void scheduleDrawable(android.graphics.drawable.Drawable arg0, global::java.lang.RunnableDelegate arg1, long arg2)
		{
			scheduleDrawable(arg0, (global::java.lang.RunnableDelegateWrapper)arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _unscheduleDrawable6015;
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._unscheduleDrawable6015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void unscheduleDrawable(android.graphics.drawable.Drawable arg0, global::java.lang.RunnableDelegate arg1)
		{
			unscheduleDrawable(arg0, (global::java.lang.RunnableDelegateWrapper)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _selectDrawable6016;
		public virtual bool selectDrawable(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._selectDrawable6016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setConstantState6017;
		protected virtual void setConstantState(android.graphics.drawable.DrawableContainer.DrawableContainerState arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._setConstantState6017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DrawableContainer6018;
		public DrawableContainer() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._DrawableContainer6018);
			Init(@__env, handle);
		}
		static DrawableContainer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.DrawableContainer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/DrawableContainer"));
			global::android.graphics.drawable.DrawableContainer._draw5994 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.DrawableContainer._getChangingConfigurations5995 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "getChangingConfigurations", "()I");
			global::android.graphics.drawable.DrawableContainer._setDither5996 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "setDither", "(Z)V");
			global::android.graphics.drawable.DrawableContainer._setAlpha5997 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "setAlpha", "(I)V");
			global::android.graphics.drawable.DrawableContainer._setColorFilter5998 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.graphics.drawable.DrawableContainer._isStateful5999 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "isStateful", "()Z");
			global::android.graphics.drawable.DrawableContainer._getCurrent6000 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "getCurrent", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.DrawableContainer._setVisible6001 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "setVisible", "(ZZ)Z");
			global::android.graphics.drawable.DrawableContainer._getOpacity6002 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "getOpacity", "()I");
			global::android.graphics.drawable.DrawableContainer._onStateChange6003 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "onStateChange", "([I)Z");
			global::android.graphics.drawable.DrawableContainer._onLevelChange6004 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "onLevelChange", "(I)Z");
			global::android.graphics.drawable.DrawableContainer._onBoundsChange6005 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.DrawableContainer._getIntrinsicWidth6006 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "getIntrinsicWidth", "()I");
			global::android.graphics.drawable.DrawableContainer._getIntrinsicHeight6007 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "getIntrinsicHeight", "()I");
			global::android.graphics.drawable.DrawableContainer._getMinimumWidth6008 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "getMinimumWidth", "()I");
			global::android.graphics.drawable.DrawableContainer._getMinimumHeight6009 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "getMinimumHeight", "()I");
			global::android.graphics.drawable.DrawableContainer._getPadding6010 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.drawable.DrawableContainer._mutate6011 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.DrawableContainer._getConstantState6012 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;");
			global::android.graphics.drawable.DrawableContainer._invalidateDrawable6013 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.graphics.drawable.DrawableContainer._scheduleDrawable6014 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V");
			global::android.graphics.drawable.DrawableContainer._unscheduleDrawable6015 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V");
			global::android.graphics.drawable.DrawableContainer._selectDrawable6016 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "selectDrawable", "(I)Z");
			global::android.graphics.drawable.DrawableContainer._setConstantState6017 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "setConstantState", "(Landroid/graphics/drawable/DrawableContainer$DrawableContainerState;)V");
			global::android.graphics.drawable.DrawableContainer._DrawableContainer6018 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
