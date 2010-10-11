namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RectF : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RectF()
		{
			InitJNI();
		}
		protected RectF(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString3709;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.RectF._toString3709)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._toString3709)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _offset3710;
		public virtual void offset(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._offset3710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._offset3710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty3711;
		public virtual bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.RectF._isEmpty3711);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._isEmpty3711);
		}
		internal static global::MonoJavaBridge.MethodId _contains3712;
		public virtual bool contains(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.RectF._contains3712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._contains3712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _contains3713;
		public virtual bool contains(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.RectF._contains3713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._contains3713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _contains3714;
		public virtual bool contains(android.graphics.RectF arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.RectF._contains3714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._contains3714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _set3715;
		public virtual void set(android.graphics.RectF arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._set3715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._set3715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _set3716;
		public virtual void set(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._set3716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._set3716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _set3717;
		public virtual void set(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._set3717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._set3717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sort3718;
		public virtual void sort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._sort3718);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._sort3718);
		}
		internal static global::MonoJavaBridge.MethodId _round3719;
		public virtual void round(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._round3719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._round3719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _intersects3720;
		public static bool intersects(android.graphics.RectF arg0, android.graphics.RectF arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.graphics.RectF.staticClass, global::android.graphics.RectF._intersects3720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _intersects3721;
		public virtual bool intersects(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.RectF._intersects3721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._intersects3721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _union3722;
		public virtual void union(android.graphics.RectF arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._union3722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._union3722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _union3723;
		public virtual void union(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._union3723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._union3723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _union3724;
		public virtual void union(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._union3724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._union3724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _centerX3725;
		public virtual float centerX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.RectF._centerX3725);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._centerX3725);
		}
		internal static global::MonoJavaBridge.MethodId _centerY3726;
		public virtual float centerY() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.RectF._centerY3726);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._centerY3726);
		}
		internal static global::MonoJavaBridge.MethodId _height3727;
		public virtual float height() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.RectF._height3727);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._height3727);
		}
		internal static global::MonoJavaBridge.MethodId _width3728;
		public virtual float width() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.RectF._width3728);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._width3728);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel3729;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._writeToParcel3729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._writeToParcel3729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents3730;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.RectF._describeContents3730);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._describeContents3730);
		}
		internal static global::MonoJavaBridge.MethodId _readFromParcel3731;
		public virtual void readFromParcel(android.os.Parcel arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._readFromParcel3731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._readFromParcel3731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEmpty3732;
		public virtual void setEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._setEmpty3732);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._setEmpty3732);
		}
		internal static global::MonoJavaBridge.MethodId _offsetTo3733;
		public virtual void offsetTo(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._offsetTo3733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._offsetTo3733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _inset3734;
		public virtual void inset(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._inset3734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._inset3734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _intersect3735;
		public virtual bool intersect(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.RectF._intersect3735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._intersect3735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _intersect3736;
		public virtual bool intersect(android.graphics.RectF arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.RectF._intersect3736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._intersect3736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIntersect3737;
		public virtual bool setIntersect(android.graphics.RectF arg0, android.graphics.RectF arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.RectF._setIntersect3737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._setIntersect3737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _roundOut3738;
		public virtual void roundOut(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._roundOut3738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._roundOut3738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _RectF3739;
		public RectF()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.RectF.staticClass, global::android.graphics.RectF._RectF3739);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RectF3740;
		public RectF(float arg0, float arg1, float arg2, float arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.RectF.staticClass, global::android.graphics.RectF._RectF3740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RectF3741;
		public RectF(android.graphics.RectF arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.RectF.staticClass, global::android.graphics.RectF._RectF3741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RectF3742;
		public RectF(android.graphics.Rect arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.RectF.staticClass, global::android.graphics.RectF._RectF3742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _left3743;
		public float left
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _top3744;
		public float top
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _right3745;
		public float right
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _bottom3746;
		public float bottom
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR3747;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.RectF.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/RectF"));
			global::android.graphics.RectF._toString3709 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "toString", "()Ljava/lang/String;");
			global::android.graphics.RectF._offset3710 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "offset", "(FF)V");
			global::android.graphics.RectF._isEmpty3711 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "isEmpty", "()Z");
			global::android.graphics.RectF._contains3712 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "contains", "(FFFF)Z");
			global::android.graphics.RectF._contains3713 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "contains", "(FF)Z");
			global::android.graphics.RectF._contains3714 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "contains", "(Landroid/graphics/RectF;)Z");
			global::android.graphics.RectF._set3715 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "set", "(Landroid/graphics/RectF;)V");
			global::android.graphics.RectF._set3716 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "set", "(FFFF)V");
			global::android.graphics.RectF._set3717 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "set", "(Landroid/graphics/Rect;)V");
			global::android.graphics.RectF._sort3718 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "sort", "()V");
			global::android.graphics.RectF._round3719 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "round", "(Landroid/graphics/Rect;)V");
			global::android.graphics.RectF._intersects3720 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.RectF.staticClass, "intersects", "(Landroid/graphics/RectF;Landroid/graphics/RectF;)Z");
			global::android.graphics.RectF._intersects3721 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "intersects", "(FFFF)Z");
			global::android.graphics.RectF._union3722 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "union", "(Landroid/graphics/RectF;)V");
			global::android.graphics.RectF._union3723 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "union", "(FFFF)V");
			global::android.graphics.RectF._union3724 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "union", "(FF)V");
			global::android.graphics.RectF._centerX3725 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "centerX", "()F");
			global::android.graphics.RectF._centerY3726 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "centerY", "()F");
			global::android.graphics.RectF._height3727 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "height", "()F");
			global::android.graphics.RectF._width3728 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "width", "()F");
			global::android.graphics.RectF._writeToParcel3729 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.graphics.RectF._describeContents3730 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "describeContents", "()I");
			global::android.graphics.RectF._readFromParcel3731 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
			global::android.graphics.RectF._setEmpty3732 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "setEmpty", "()V");
			global::android.graphics.RectF._offsetTo3733 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "offsetTo", "(FF)V");
			global::android.graphics.RectF._inset3734 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "inset", "(FF)V");
			global::android.graphics.RectF._intersect3735 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "intersect", "(FFFF)Z");
			global::android.graphics.RectF._intersect3736 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "intersect", "(Landroid/graphics/RectF;)Z");
			global::android.graphics.RectF._setIntersect3737 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "setIntersect", "(Landroid/graphics/RectF;Landroid/graphics/RectF;)Z");
			global::android.graphics.RectF._roundOut3738 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "roundOut", "(Landroid/graphics/Rect;)V");
			global::android.graphics.RectF._RectF3739 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "<init>", "()V");
			global::android.graphics.RectF._RectF3740 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "<init>", "(FFFF)V");
			global::android.graphics.RectF._RectF3741 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "<init>", "(Landroid/graphics/RectF;)V");
			global::android.graphics.RectF._RectF3742 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "<init>", "(Landroid/graphics/Rect;)V");
		}
	}
}
