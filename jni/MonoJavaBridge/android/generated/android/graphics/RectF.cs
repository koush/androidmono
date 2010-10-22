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
		internal static global::MonoJavaBridge.MethodId _toString5690;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.RectF._toString5690)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._toString5690)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _offset5691;
		public virtual void offset(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._offset5691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._offset5691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty5692;
		public virtual bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.RectF._isEmpty5692);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._isEmpty5692);
		}
		internal static global::MonoJavaBridge.MethodId _contains5693;
		public virtual bool contains(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.RectF._contains5693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._contains5693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _contains5694;
		public virtual bool contains(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.RectF._contains5694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._contains5694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _contains5695;
		public virtual bool contains(android.graphics.RectF arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.RectF._contains5695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._contains5695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _set5696;
		public virtual void set(android.graphics.RectF arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._set5696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._set5696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _set5697;
		public virtual void set(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._set5697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._set5697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _set5698;
		public virtual void set(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._set5698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._set5698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sort5699;
		public virtual void sort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._sort5699);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._sort5699);
		}
		internal static global::MonoJavaBridge.MethodId _round5700;
		public virtual void round(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._round5700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._round5700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _intersects5701;
		public static bool intersects(android.graphics.RectF arg0, android.graphics.RectF arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.graphics.RectF.staticClass, global::android.graphics.RectF._intersects5701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _intersects5702;
		public virtual bool intersects(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.RectF._intersects5702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._intersects5702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _union5703;
		public virtual void union(android.graphics.RectF arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._union5703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._union5703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _union5704;
		public virtual void union(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._union5704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._union5704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _union5705;
		public virtual void union(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._union5705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._union5705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _centerX5706;
		public virtual float centerX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.RectF._centerX5706);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._centerX5706);
		}
		internal static global::MonoJavaBridge.MethodId _centerY5707;
		public virtual float centerY() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.RectF._centerY5707);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._centerY5707);
		}
		internal static global::MonoJavaBridge.MethodId _height5708;
		public virtual float height() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.RectF._height5708);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._height5708);
		}
		internal static global::MonoJavaBridge.MethodId _width5709;
		public virtual float width() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.graphics.RectF._width5709);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._width5709);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel5710;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._writeToParcel5710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._writeToParcel5710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents5711;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.RectF._describeContents5711);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._describeContents5711);
		}
		internal static global::MonoJavaBridge.MethodId _readFromParcel5712;
		public virtual void readFromParcel(android.os.Parcel arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._readFromParcel5712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._readFromParcel5712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEmpty5713;
		public virtual void setEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._setEmpty5713);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._setEmpty5713);
		}
		internal static global::MonoJavaBridge.MethodId _offsetTo5714;
		public virtual void offsetTo(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._offsetTo5714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._offsetTo5714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _inset5715;
		public virtual void inset(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._inset5715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._inset5715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _intersect5716;
		public virtual bool intersect(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.RectF._intersect5716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._intersect5716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _intersect5717;
		public virtual bool intersect(android.graphics.RectF arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.RectF._intersect5717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._intersect5717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIntersect5718;
		public virtual bool setIntersect(android.graphics.RectF arg0, android.graphics.RectF arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.RectF._setIntersect5718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._setIntersect5718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _roundOut5719;
		public virtual void roundOut(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.RectF._roundOut5719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.RectF.staticClass, global::android.graphics.RectF._roundOut5719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _RectF5720;
		public RectF()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.RectF.staticClass, global::android.graphics.RectF._RectF5720);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RectF5721;
		public RectF(float arg0, float arg1, float arg2, float arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.RectF.staticClass, global::android.graphics.RectF._RectF5721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RectF5722;
		public RectF(android.graphics.RectF arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.RectF.staticClass, global::android.graphics.RectF._RectF5722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RectF5723;
		public RectF(android.graphics.Rect arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.RectF.staticClass, global::android.graphics.RectF._RectF5723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _left5724;
		public float left
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _left5724);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _top5725;
		public float top
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _top5725);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _right5726;
		public float right
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _right5726);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _bottom5727;
		public float bottom
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _bottom5727);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR5728;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.graphics.RectF.staticClass, _CREATOR5728)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.RectF.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/RectF"));
			global::android.graphics.RectF._toString5690 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "toString", "()Ljava/lang/String;");
			global::android.graphics.RectF._offset5691 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "offset", "(FF)V");
			global::android.graphics.RectF._isEmpty5692 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "isEmpty", "()Z");
			global::android.graphics.RectF._contains5693 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "contains", "(FFFF)Z");
			global::android.graphics.RectF._contains5694 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "contains", "(FF)Z");
			global::android.graphics.RectF._contains5695 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "contains", "(Landroid/graphics/RectF;)Z");
			global::android.graphics.RectF._set5696 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "set", "(Landroid/graphics/RectF;)V");
			global::android.graphics.RectF._set5697 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "set", "(FFFF)V");
			global::android.graphics.RectF._set5698 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "set", "(Landroid/graphics/Rect;)V");
			global::android.graphics.RectF._sort5699 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "sort", "()V");
			global::android.graphics.RectF._round5700 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "round", "(Landroid/graphics/Rect;)V");
			global::android.graphics.RectF._intersects5701 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.RectF.staticClass, "intersects", "(Landroid/graphics/RectF;Landroid/graphics/RectF;)Z");
			global::android.graphics.RectF._intersects5702 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "intersects", "(FFFF)Z");
			global::android.graphics.RectF._union5703 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "union", "(Landroid/graphics/RectF;)V");
			global::android.graphics.RectF._union5704 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "union", "(FFFF)V");
			global::android.graphics.RectF._union5705 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "union", "(FF)V");
			global::android.graphics.RectF._centerX5706 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "centerX", "()F");
			global::android.graphics.RectF._centerY5707 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "centerY", "()F");
			global::android.graphics.RectF._height5708 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "height", "()F");
			global::android.graphics.RectF._width5709 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "width", "()F");
			global::android.graphics.RectF._writeToParcel5710 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.graphics.RectF._describeContents5711 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "describeContents", "()I");
			global::android.graphics.RectF._readFromParcel5712 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
			global::android.graphics.RectF._setEmpty5713 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "setEmpty", "()V");
			global::android.graphics.RectF._offsetTo5714 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "offsetTo", "(FF)V");
			global::android.graphics.RectF._inset5715 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "inset", "(FF)V");
			global::android.graphics.RectF._intersect5716 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "intersect", "(FFFF)Z");
			global::android.graphics.RectF._intersect5717 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "intersect", "(Landroid/graphics/RectF;)Z");
			global::android.graphics.RectF._setIntersect5718 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "setIntersect", "(Landroid/graphics/RectF;Landroid/graphics/RectF;)Z");
			global::android.graphics.RectF._roundOut5719 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "roundOut", "(Landroid/graphics/Rect;)V");
			global::android.graphics.RectF._RectF5720 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "<init>", "()V");
			global::android.graphics.RectF._RectF5721 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "<init>", "(FFFF)V");
			global::android.graphics.RectF._RectF5722 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "<init>", "(Landroid/graphics/RectF;)V");
			global::android.graphics.RectF._RectF5723 = @__env.GetMethodIDNoThrow(global::android.graphics.RectF.staticClass, "<init>", "(Landroid/graphics/Rect;)V");
			global::android.graphics.RectF._left5724 = @__env.GetFieldIDNoThrow(global::android.graphics.RectF.staticClass, "left", "F");
			global::android.graphics.RectF._top5725 = @__env.GetFieldIDNoThrow(global::android.graphics.RectF.staticClass, "top", "F");
			global::android.graphics.RectF._right5726 = @__env.GetFieldIDNoThrow(global::android.graphics.RectF.staticClass, "right", "F");
			global::android.graphics.RectF._bottom5727 = @__env.GetFieldIDNoThrow(global::android.graphics.RectF.staticClass, "bottom", "F");
			global::android.graphics.RectF._CREATOR5728 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.RectF.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
