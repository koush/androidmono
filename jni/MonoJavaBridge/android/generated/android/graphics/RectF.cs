namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RectF : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RectF(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString5709;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.RectF._toString5709)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._toString5709)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _offset5710;
		public virtual void offset(float arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._offset5710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._offset5710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty5711;
		public virtual bool isEmpty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.RectF._isEmpty5711);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._isEmpty5711);
		}
		internal static global::MonoJavaBridge.MethodId _contains5712;
		public virtual bool contains(float arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.RectF._contains5712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._contains5712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _contains5713;
		public virtual bool contains(float arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.RectF._contains5713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._contains5713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _contains5714;
		public virtual bool contains(android.graphics.RectF arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.RectF._contains5714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._contains5714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _set5715;
		public virtual void set(android.graphics.RectF arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._set5715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._set5715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _set5716;
		public virtual void set(float arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._set5716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._set5716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _set5717;
		public virtual void set(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._set5717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._set5717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sort5718;
		public virtual void sort()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._sort5718);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._sort5718);
		}
		internal static global::MonoJavaBridge.MethodId _round5719;
		public virtual void round(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._round5719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._round5719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _intersects5720;
		public static bool intersects(android.graphics.RectF arg0, android.graphics.RectF arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.graphics.RectF.staticClass, global::android.graphics.RectF._intersects5720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _intersects5721;
		public virtual bool intersects(float arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.RectF._intersects5721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._intersects5721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _union5722;
		public virtual void union(android.graphics.RectF arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._union5722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._union5722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _union5723;
		public virtual void union(float arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._union5723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._union5723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _union5724;
		public virtual void union(float arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._union5724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._union5724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _centerX5725;
		public virtual float centerX()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.RectF._centerX5725);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._centerX5725);
		}
		internal static global::MonoJavaBridge.MethodId _centerY5726;
		public virtual float centerY()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.RectF._centerY5726);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._centerY5726);
		}
		internal static global::MonoJavaBridge.MethodId _height5727;
		public virtual float height()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.RectF._height5727);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._height5727);
		}
		internal static global::MonoJavaBridge.MethodId _width5728;
		public virtual float width()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.RectF._width5728);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._width5728);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel5729;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._writeToParcel5729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._writeToParcel5729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents5730;
		public virtual int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.RectF._describeContents5730);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._describeContents5730);
		}
		internal static global::MonoJavaBridge.MethodId _readFromParcel5731;
		public virtual void readFromParcel(android.os.Parcel arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._readFromParcel5731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._readFromParcel5731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEmpty5732;
		public virtual void setEmpty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._setEmpty5732);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._setEmpty5732);
		}
		internal static global::MonoJavaBridge.MethodId _offsetTo5733;
		public virtual void offsetTo(float arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._offsetTo5733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._offsetTo5733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _inset5734;
		public virtual void inset(float arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._inset5734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._inset5734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _intersect5735;
		public virtual bool intersect(float arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.RectF._intersect5735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._intersect5735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _intersect5736;
		public virtual bool intersect(android.graphics.RectF arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.RectF._intersect5736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._intersect5736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIntersect5737;
		public virtual bool setIntersect(android.graphics.RectF arg0, android.graphics.RectF arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.RectF._setIntersect5737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._setIntersect5737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _roundOut5738;
		public virtual void roundOut(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._roundOut5738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._roundOut5738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _RectF5739;
		public RectF() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.RectF.staticClass, global::android.graphics.RectF._RectF5739);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RectF5740;
		public RectF(float arg0, float arg1, float arg2, float arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.RectF.staticClass, global::android.graphics.RectF._RectF5740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RectF5741;
		public RectF(android.graphics.RectF arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.RectF.staticClass, global::android.graphics.RectF._RectF5741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RectF5742;
		public RectF(android.graphics.Rect arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.RectF.staticClass, global::android.graphics.RectF._RectF5742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _left5743;
		public float left
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _left5743);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _top5744;
		public float top
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _top5744);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _right5745;
		public float right
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _right5745);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _bottom5746;
		public float bottom
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _bottom5746);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR5747;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.graphics.RectF.staticClass, _CREATOR5747)) as android.os.Parcelable_Creator;
			}
		}
		static RectF()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.RectF.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/RectF"));
			global::android.graphics.RectF._toString5709 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "toString", "()Ljava/lang/String;");
			global::android.graphics.RectF._offset5710 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "offset", "(FF)V");
			global::android.graphics.RectF._isEmpty5711 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "isEmpty", "()Z");
			global::android.graphics.RectF._contains5712 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "contains", "(FFFF)Z");
			global::android.graphics.RectF._contains5713 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "contains", "(FF)Z");
			global::android.graphics.RectF._contains5714 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "contains", "(Landroid/graphics/RectF;)Z");
			global::android.graphics.RectF._set5715 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "set", "(Landroid/graphics/RectF;)V");
			global::android.graphics.RectF._set5716 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "set", "(FFFF)V");
			global::android.graphics.RectF._set5717 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "set", "(Landroid/graphics/Rect;)V");
			global::android.graphics.RectF._sort5718 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "sort", "()V");
			global::android.graphics.RectF._round5719 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "round", "(Landroid/graphics/Rect;)V");
			global::android.graphics.RectF._intersects5720 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.RectF.staticClass, "intersects", "(Landroid/graphics/RectF;Landroid/graphics/RectF;)Z");
			global::android.graphics.RectF._intersects5721 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "intersects", "(FFFF)Z");
			global::android.graphics.RectF._union5722 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "union", "(Landroid/graphics/RectF;)V");
			global::android.graphics.RectF._union5723 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "union", "(FFFF)V");
			global::android.graphics.RectF._union5724 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "union", "(FF)V");
			global::android.graphics.RectF._centerX5725 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "centerX", "()F");
			global::android.graphics.RectF._centerY5726 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "centerY", "()F");
			global::android.graphics.RectF._height5727 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "height", "()F");
			global::android.graphics.RectF._width5728 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "width", "()F");
			global::android.graphics.RectF._writeToParcel5729 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.graphics.RectF._describeContents5730 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "describeContents", "()I");
			global::android.graphics.RectF._readFromParcel5731 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
			global::android.graphics.RectF._setEmpty5732 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "setEmpty", "()V");
			global::android.graphics.RectF._offsetTo5733 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "offsetTo", "(FF)V");
			global::android.graphics.RectF._inset5734 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "inset", "(FF)V");
			global::android.graphics.RectF._intersect5735 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "intersect", "(FFFF)Z");
			global::android.graphics.RectF._intersect5736 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "intersect", "(Landroid/graphics/RectF;)Z");
			global::android.graphics.RectF._setIntersect5737 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "setIntersect", "(Landroid/graphics/RectF;Landroid/graphics/RectF;)Z");
			global::android.graphics.RectF._roundOut5738 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "roundOut", "(Landroid/graphics/Rect;)V");
			global::android.graphics.RectF._RectF5739 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "<init>", "()V");
			global::android.graphics.RectF._RectF5740 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "<init>", "(FFFF)V");
			global::android.graphics.RectF._RectF5741 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "<init>", "(Landroid/graphics/RectF;)V");
			global::android.graphics.RectF._RectF5742 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "<init>", "(Landroid/graphics/Rect;)V");
			global::android.graphics.RectF._left5743 = @__env.GetFieldIDNoThrow(global::android.graphics.RectF.staticClass, "left", "F");
			global::android.graphics.RectF._top5744 = @__env.GetFieldIDNoThrow(global::android.graphics.RectF.staticClass, "top", "F");
			global::android.graphics.RectF._right5745 = @__env.GetFieldIDNoThrow(global::android.graphics.RectF.staticClass, "right", "F");
			global::android.graphics.RectF._bottom5746 = @__env.GetFieldIDNoThrow(global::android.graphics.RectF.staticClass, "bottom", "F");
			global::android.graphics.RectF._CREATOR5747 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.RectF.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
