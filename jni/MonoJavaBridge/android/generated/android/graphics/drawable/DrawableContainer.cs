namespace android.graphics.drawable
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DrawableContainer : android.graphics.drawable.Drawable, android.graphics.drawable.Drawable.Callback
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DrawableContainer()
		{
			InitJNI();
		}
		protected DrawableContainer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass(typeof(global::android.graphics.drawable.DrawableContainer.DrawableContainerState_))]
		public abstract partial class DrawableContainerState : android.graphics.drawable.Drawable.ConstantState
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static DrawableContainerState()
			{
				InitJNI();
			}
			protected DrawableContainerState(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _getChangingConfigurations5958;
			public override int getChangingConfigurations() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChangingConfigurations5958);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChangingConfigurations5958);
			}
			internal static global::MonoJavaBridge.MethodId _isStateful5959;
			public virtual bool isStateful() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._isStateful5959);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._isStateful5959);
			}
			internal static global::MonoJavaBridge.MethodId _getOpacity5960;
			public virtual int getOpacity() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getOpacity5960);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getOpacity5960);
			}
			internal static global::MonoJavaBridge.MethodId _getChildCount5961;
			public virtual int getChildCount() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChildCount5961);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChildCount5961);
			}
			internal static global::MonoJavaBridge.MethodId _addChild5962;
			public virtual int addChild(android.graphics.drawable.Drawable arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._addChild5962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._addChild5962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _getChildren5963;
			public virtual global::android.graphics.drawable.Drawable[] getChildren() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.drawable.Drawable>(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChildren5963)) as android.graphics.drawable.Drawable[];
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.drawable.Drawable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChildren5963)) as android.graphics.drawable.Drawable[];
			}
			internal static global::MonoJavaBridge.MethodId _setVariablePadding5964;
			public virtual void setVariablePadding(bool arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._setVariablePadding5964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._setVariablePadding5964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _getConstantPadding5965;
			public virtual global::android.graphics.Rect getConstantPadding() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Rect>(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantPadding5965)) as android.graphics.Rect;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Rect>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantPadding5965)) as android.graphics.Rect;
			}
			internal static global::MonoJavaBridge.MethodId _setConstantSize5966;
			public virtual void setConstantSize(bool arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._setConstantSize5966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._setConstantSize5966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _isConstantSize5967;
			public virtual bool isConstantSize() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._isConstantSize5967);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._isConstantSize5967);
			}
			internal static global::MonoJavaBridge.MethodId _getConstantWidth5968;
			public virtual int getConstantWidth() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantWidth5968);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantWidth5968);
			}
			internal static global::MonoJavaBridge.MethodId _getConstantHeight5969;
			public virtual int getConstantHeight() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantHeight5969);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantHeight5969);
			}
			internal static global::MonoJavaBridge.MethodId _getConstantMinimumWidth5970;
			public virtual int getConstantMinimumWidth() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantMinimumWidth5970);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantMinimumWidth5970);
			}
			internal static global::MonoJavaBridge.MethodId _getConstantMinimumHeight5971;
			public virtual int getConstantMinimumHeight() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantMinimumHeight5971);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantMinimumHeight5971);
			}
			internal static global::MonoJavaBridge.MethodId _growArray5972;
			public virtual void growArray(int arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._growArray5972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._growArray5972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _canConstantState5973;
			public virtual bool canConstantState() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._canConstantState5973);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState._canConstantState5973);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/DrawableContainer$DrawableContainerState"));
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChangingConfigurations5958 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getChangingConfigurations", "()I");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._isStateful5959 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "isStateful", "()Z");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getOpacity5960 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getOpacity", "()I");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChildCount5961 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getChildCount", "()I");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._addChild5962 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "addChild", "(Landroid/graphics/drawable/Drawable;)I");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getChildren5963 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getChildren", "()[Landroid/graphics/drawable/Drawable;");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._setVariablePadding5964 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "setVariablePadding", "(Z)V");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantPadding5965 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getConstantPadding", "()Landroid/graphics/Rect;");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._setConstantSize5966 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "setConstantSize", "(Z)V");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._isConstantSize5967 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "isConstantSize", "()Z");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantWidth5968 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getConstantWidth", "()I");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantHeight5969 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getConstantHeight", "()I");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantMinimumWidth5970 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getConstantMinimumWidth", "()I");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._getConstantMinimumHeight5971 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "getConstantMinimumHeight", "()I");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._growArray5972 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "growArray", "(II)V");
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState._canConstantState5973 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState.staticClass, "canConstantState", "()Z");
			}
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.graphics.drawable.DrawableContainer.DrawableContainerState))]
		public sealed partial class DrawableContainerState_ : android.graphics.drawable.DrawableContainer.DrawableContainerState
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static DrawableContainerState_()
			{
				InitJNI();
			}
			internal DrawableContainerState_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _newDrawable5974;
			public override global::android.graphics.drawable.Drawable newDrawable() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState_._newDrawable5974)) as android.graphics.drawable.Drawable;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.DrawableContainerState_.staticClass, global::android.graphics.drawable.DrawableContainer.DrawableContainerState_._newDrawable5974)) as android.graphics.drawable.Drawable;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/DrawableContainer$DrawableContainerState"));
				global::android.graphics.drawable.DrawableContainer.DrawableContainerState_._newDrawable5974 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.DrawableContainerState_.staticClass, "newDrawable", "()Landroid/graphics/drawable/Drawable;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _draw5975;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._draw5975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._draw5975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ChangingConfigurations
		{
			get
			{
				return getChangingConfigurations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChangingConfigurations5976;
		public override int getChangingConfigurations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._getChangingConfigurations5976);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getChangingConfigurations5976);
		}
		internal static global::MonoJavaBridge.MethodId _setDither5977;
		public override void setDither(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._setDither5977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._setDither5977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAlpha5978;
		public override void setAlpha(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._setAlpha5978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._setAlpha5978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setColorFilter5979;
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._setColorFilter5979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._setColorFilter5979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isStateful5980;
		public override bool isStateful() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._isStateful5980);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._isStateful5980);
		}
		public new global::android.graphics.drawable.Drawable Current
		{
			get
			{
				return getCurrent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrent5981;
		public override global::android.graphics.drawable.Drawable getCurrent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._getCurrent5981)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getCurrent5981)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _setVisible5982;
		public override bool setVisible(bool arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._setVisible5982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._setVisible5982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int Opacity
		{
			get
			{
				return getOpacity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOpacity5983;
		public override int getOpacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._getOpacity5983);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getOpacity5983);
		}
		internal static global::MonoJavaBridge.MethodId _onStateChange5984;
		protected override bool onStateChange(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._onStateChange5984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._onStateChange5984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLevelChange5985;
		protected override bool onLevelChange(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._onLevelChange5985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._onLevelChange5985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onBoundsChange5986;
		protected override void onBoundsChange(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._onBoundsChange5986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._onBoundsChange5986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int IntrinsicWidth
		{
			get
			{
				return getIntrinsicWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicWidth5987;
		public override int getIntrinsicWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._getIntrinsicWidth5987);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getIntrinsicWidth5987);
		}
		public new int IntrinsicHeight
		{
			get
			{
				return getIntrinsicHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIntrinsicHeight5988;
		public override int getIntrinsicHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._getIntrinsicHeight5988);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getIntrinsicHeight5988);
		}
		public new int MinimumWidth
		{
			get
			{
				return getMinimumWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMinimumWidth5989;
		public override int getMinimumWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._getMinimumWidth5989);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getMinimumWidth5989);
		}
		public new int MinimumHeight
		{
			get
			{
				return getMinimumHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMinimumHeight5990;
		public override int getMinimumHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._getMinimumHeight5990);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getMinimumHeight5990);
		}
		internal static global::MonoJavaBridge.MethodId _getPadding5991;
		public override bool getPadding(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._getPadding5991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getPadding5991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _mutate5992;
		public override global::android.graphics.drawable.Drawable mutate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._mutate5992)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._mutate5992)) as android.graphics.drawable.Drawable;
		}
		public new global::android.graphics.drawable.Drawable.ConstantState ConstantState
		{
			get
			{
				return getConstantState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConstantState5993;
		public override global::android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._getConstantState5993)) as android.graphics.drawable.Drawable.ConstantState;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._getConstantState5993)) as android.graphics.drawable.Drawable.ConstantState;
		}
		internal static global::MonoJavaBridge.MethodId _invalidateDrawable5994;
		public virtual void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._invalidateDrawable5994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._invalidateDrawable5994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _scheduleDrawable5995;
		public virtual void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._scheduleDrawable5995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._scheduleDrawable5995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _unscheduleDrawable5996;
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._unscheduleDrawable5996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._unscheduleDrawable5996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _selectDrawable5997;
		public virtual bool selectDrawable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._selectDrawable5997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._selectDrawable5997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setConstantState5998;
		protected virtual void setConstantState(android.graphics.drawable.DrawableContainer.DrawableContainerState arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer._setConstantState5998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._setConstantState5998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DrawableContainer5999;
		public DrawableContainer()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.DrawableContainer.staticClass, global::android.graphics.drawable.DrawableContainer._DrawableContainer5999);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.DrawableContainer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/DrawableContainer"));
			global::android.graphics.drawable.DrawableContainer._draw5975 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.DrawableContainer._getChangingConfigurations5976 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "getChangingConfigurations", "()I");
			global::android.graphics.drawable.DrawableContainer._setDither5977 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "setDither", "(Z)V");
			global::android.graphics.drawable.DrawableContainer._setAlpha5978 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "setAlpha", "(I)V");
			global::android.graphics.drawable.DrawableContainer._setColorFilter5979 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.graphics.drawable.DrawableContainer._isStateful5980 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "isStateful", "()Z");
			global::android.graphics.drawable.DrawableContainer._getCurrent5981 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "getCurrent", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.DrawableContainer._setVisible5982 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "setVisible", "(ZZ)Z");
			global::android.graphics.drawable.DrawableContainer._getOpacity5983 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "getOpacity", "()I");
			global::android.graphics.drawable.DrawableContainer._onStateChange5984 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "onStateChange", "([I)Z");
			global::android.graphics.drawable.DrawableContainer._onLevelChange5985 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "onLevelChange", "(I)Z");
			global::android.graphics.drawable.DrawableContainer._onBoundsChange5986 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.DrawableContainer._getIntrinsicWidth5987 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "getIntrinsicWidth", "()I");
			global::android.graphics.drawable.DrawableContainer._getIntrinsicHeight5988 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "getIntrinsicHeight", "()I");
			global::android.graphics.drawable.DrawableContainer._getMinimumWidth5989 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "getMinimumWidth", "()I");
			global::android.graphics.drawable.DrawableContainer._getMinimumHeight5990 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "getMinimumHeight", "()I");
			global::android.graphics.drawable.DrawableContainer._getPadding5991 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.drawable.DrawableContainer._mutate5992 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.DrawableContainer._getConstantState5993 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;");
			global::android.graphics.drawable.DrawableContainer._invalidateDrawable5994 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.graphics.drawable.DrawableContainer._scheduleDrawable5995 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V");
			global::android.graphics.drawable.DrawableContainer._unscheduleDrawable5996 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V");
			global::android.graphics.drawable.DrawableContainer._selectDrawable5997 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "selectDrawable", "(I)Z");
			global::android.graphics.drawable.DrawableContainer._setConstantState5998 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "setConstantState", "(Landroid/graphics/drawable/DrawableContainer$DrawableContainerState;)V");
			global::android.graphics.drawable.DrawableContainer._DrawableContainer5999 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.DrawableContainer.staticClass, "<init>", "()V");
		}
	}
}
