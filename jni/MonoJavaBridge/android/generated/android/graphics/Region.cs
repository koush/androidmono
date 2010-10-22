namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Region : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Region()
		{
			InitJNI();
		}
		protected Region(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Op : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Op()
			{
				InitJNI();
			}
			internal Op(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values5729;
			public static global::android.graphics.Region.Op[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Region.Op>(@__env.CallStaticObjectMethod(android.graphics.Region.Op.staticClass, global::android.graphics.Region.Op._values5729)) as android.graphics.Region.Op[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf5730;
			public static global::android.graphics.Region.Op valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Region.Op>(@__env.CallStaticObjectMethod(android.graphics.Region.Op.staticClass, global::android.graphics.Region.Op._valueOf5730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Region.Op;
			}
			internal static global::MonoJavaBridge.FieldId _DIFFERENCE5731;
			public static global::android.graphics.Region.Op DIFFERENCE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Region.Op>(@__env.GetStaticObjectField(global::android.graphics.Region.Op.staticClass, _DIFFERENCE5731)) as android.graphics.Region.Op;
				}
			}
			internal static global::MonoJavaBridge.FieldId _INTERSECT5732;
			public static global::android.graphics.Region.Op INTERSECT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Region.Op>(@__env.GetStaticObjectField(global::android.graphics.Region.Op.staticClass, _INTERSECT5732)) as android.graphics.Region.Op;
				}
			}
			internal static global::MonoJavaBridge.FieldId _REPLACE5733;
			public static global::android.graphics.Region.Op REPLACE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Region.Op>(@__env.GetStaticObjectField(global::android.graphics.Region.Op.staticClass, _REPLACE5733)) as android.graphics.Region.Op;
				}
			}
			internal static global::MonoJavaBridge.FieldId _REVERSE_DIFFERENCE5734;
			public static global::android.graphics.Region.Op REVERSE_DIFFERENCE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Region.Op>(@__env.GetStaticObjectField(global::android.graphics.Region.Op.staticClass, _REVERSE_DIFFERENCE5734)) as android.graphics.Region.Op;
				}
			}
			internal static global::MonoJavaBridge.FieldId _UNION5735;
			public static global::android.graphics.Region.Op UNION
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Region.Op>(@__env.GetStaticObjectField(global::android.graphics.Region.Op.staticClass, _UNION5735)) as android.graphics.Region.Op;
				}
			}
			internal static global::MonoJavaBridge.FieldId _XOR5736;
			public static global::android.graphics.Region.Op XOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Region.Op>(@__env.GetStaticObjectField(global::android.graphics.Region.Op.staticClass, _XOR5736)) as android.graphics.Region.Op;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Region.Op.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Region$Op"));
				global::android.graphics.Region.Op._values5729 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Region.Op.staticClass, "values", "()[Landroid/graphics/Region/Op;");
				global::android.graphics.Region.Op._valueOf5730 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Region.Op.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Region$Op;");
				global::android.graphics.Region.Op._DIFFERENCE5731 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Region.Op.staticClass, "DIFFERENCE", "Landroid/graphics/Region$Op;");
				global::android.graphics.Region.Op._INTERSECT5732 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Region.Op.staticClass, "INTERSECT", "Landroid/graphics/Region$Op;");
				global::android.graphics.Region.Op._REPLACE5733 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Region.Op.staticClass, "REPLACE", "Landroid/graphics/Region$Op;");
				global::android.graphics.Region.Op._REVERSE_DIFFERENCE5734 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Region.Op.staticClass, "REVERSE_DIFFERENCE", "Landroid/graphics/Region$Op;");
				global::android.graphics.Region.Op._UNION5735 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Region.Op.staticClass, "UNION", "Landroid/graphics/Region$Op;");
				global::android.graphics.Region.Op._XOR5736 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Region.Op.staticClass, "XOR", "Landroid/graphics/Region$Op;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize5737;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Region._finalize5737);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._finalize5737);
		}
		internal static global::MonoJavaBridge.MethodId _equals5738;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._equals5738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._equals5738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty5739;
		public virtual bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._isEmpty5739);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._isEmpty5739);
		}
		internal static global::MonoJavaBridge.MethodId _contains5740;
		public virtual bool contains(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._contains5740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._contains5740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _set5741;
		public virtual bool set(android.graphics.Region arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._set5741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._set5741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _set5742;
		public virtual bool set(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._set5742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._set5742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _set5743;
		public virtual bool set(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._set5743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._set5743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _union5744;
		public virtual bool union(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._union5744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._union5744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel5745;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Region._writeToParcel5745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._writeToParcel5745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents5746;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Region._describeContents5746);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._describeContents5746);
		}
		public new global::android.graphics.Rect Bounds
		{
			get
			{
				return getBounds();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBounds5747;
		public virtual global::android.graphics.Rect getBounds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Rect>(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Region._getBounds5747)) as android.graphics.Rect;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Rect>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._getBounds5747)) as android.graphics.Rect;
		}
		internal static global::MonoJavaBridge.MethodId _getBounds5748;
		public virtual bool getBounds(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._getBounds5748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._getBounds5748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _translate5749;
		public virtual void translate(int arg0, int arg1, android.graphics.Region arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Region._translate5749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._translate5749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _translate5750;
		public virtual void translate(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Region._translate5750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._translate5750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _op5751;
		public virtual bool op(android.graphics.Rect arg0, android.graphics.Region arg1, android.graphics.Region.Op arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._op5751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._op5751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _op5752;
		public virtual bool op(int arg0, int arg1, int arg2, int arg3, android.graphics.Region.Op arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._op5752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._op5752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _op5753;
		public virtual bool op(android.graphics.Rect arg0, android.graphics.Region.Op arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._op5753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._op5753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _op5754;
		public virtual bool op(android.graphics.Region arg0, android.graphics.Region arg1, android.graphics.Region.Op arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._op5754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._op5754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _op5755;
		public virtual bool op(android.graphics.Region arg0, android.graphics.Region.Op arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._op5755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._op5755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _quickReject5756;
		public virtual bool quickReject(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._quickReject5756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._quickReject5756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _quickReject5757;
		public virtual bool quickReject(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._quickReject5757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._quickReject5757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _quickReject5758;
		public virtual bool quickReject(android.graphics.Region arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._quickReject5758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._quickReject5758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEmpty5759;
		public virtual void setEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Region._setEmpty5759);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._setEmpty5759);
		}
		internal static global::MonoJavaBridge.MethodId _setPath5760;
		public virtual bool setPath(android.graphics.Path arg0, android.graphics.Region arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._setPath5760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._setPath5760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isRect5761;
		public virtual bool isRect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._isRect5761);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._isRect5761);
		}
		internal static global::MonoJavaBridge.MethodId _isComplex5762;
		public virtual bool isComplex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._isComplex5762);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._isComplex5762);
		}
		public new global::android.graphics.Path BoundaryPath
		{
			get
			{
				return getBoundaryPath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBoundaryPath5763;
		public virtual global::android.graphics.Path getBoundaryPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Region._getBoundaryPath5763)) as android.graphics.Path;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._getBoundaryPath5763)) as android.graphics.Path;
		}
		internal static global::MonoJavaBridge.MethodId _getBoundaryPath5764;
		public virtual bool getBoundaryPath(android.graphics.Path arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._getBoundaryPath5764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._getBoundaryPath5764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _quickContains5765;
		public virtual bool quickContains(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._quickContains5765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._quickContains5765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _quickContains5766;
		public virtual bool quickContains(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Region._quickContains5766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Region.staticClass, global::android.graphics.Region._quickContains5766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Region5767;
		public Region()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Region.staticClass, global::android.graphics.Region._Region5767);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Region5768;
		public Region(android.graphics.Region arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Region.staticClass, global::android.graphics.Region._Region5768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Region5769;
		public Region(android.graphics.Rect arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Region.staticClass, global::android.graphics.Region._Region5769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Region5770;
		public Region(int arg0, int arg1, int arg2, int arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Region.staticClass, global::android.graphics.Region._Region5770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR5771;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.graphics.Region.staticClass, _CREATOR5771)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Region.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Region"));
			global::android.graphics.Region._finalize5737 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "finalize", "()V");
			global::android.graphics.Region._equals5738 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.graphics.Region._isEmpty5739 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "isEmpty", "()Z");
			global::android.graphics.Region._contains5740 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "contains", "(II)Z");
			global::android.graphics.Region._set5741 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "set", "(Landroid/graphics/Region;)Z");
			global::android.graphics.Region._set5742 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "set", "(IIII)Z");
			global::android.graphics.Region._set5743 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "set", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.Region._union5744 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "union", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.Region._writeToParcel5745 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.graphics.Region._describeContents5746 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "describeContents", "()I");
			global::android.graphics.Region._getBounds5747 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "getBounds", "()Landroid/graphics/Rect;");
			global::android.graphics.Region._getBounds5748 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "getBounds", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.Region._translate5749 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "translate", "(IILandroid/graphics/Region;)V");
			global::android.graphics.Region._translate5750 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "translate", "(II)V");
			global::android.graphics.Region._op5751 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "op", "(Landroid/graphics/Rect;Landroid/graphics/Region;Landroid/graphics/Region$Op;)Z");
			global::android.graphics.Region._op5752 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "op", "(IIIILandroid/graphics/Region$Op;)Z");
			global::android.graphics.Region._op5753 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "op", "(Landroid/graphics/Rect;Landroid/graphics/Region$Op;)Z");
			global::android.graphics.Region._op5754 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "op", "(Landroid/graphics/Region;Landroid/graphics/Region;Landroid/graphics/Region$Op;)Z");
			global::android.graphics.Region._op5755 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "op", "(Landroid/graphics/Region;Landroid/graphics/Region$Op;)Z");
			global::android.graphics.Region._quickReject5756 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "quickReject", "(IIII)Z");
			global::android.graphics.Region._quickReject5757 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "quickReject", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.Region._quickReject5758 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "quickReject", "(Landroid/graphics/Region;)Z");
			global::android.graphics.Region._setEmpty5759 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "setEmpty", "()V");
			global::android.graphics.Region._setPath5760 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "setPath", "(Landroid/graphics/Path;Landroid/graphics/Region;)Z");
			global::android.graphics.Region._isRect5761 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "isRect", "()Z");
			global::android.graphics.Region._isComplex5762 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "isComplex", "()Z");
			global::android.graphics.Region._getBoundaryPath5763 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "getBoundaryPath", "()Landroid/graphics/Path;");
			global::android.graphics.Region._getBoundaryPath5764 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "getBoundaryPath", "(Landroid/graphics/Path;)Z");
			global::android.graphics.Region._quickContains5765 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "quickContains", "(IIII)Z");
			global::android.graphics.Region._quickContains5766 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "quickContains", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.Region._Region5767 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "<init>", "()V");
			global::android.graphics.Region._Region5768 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "<init>", "(Landroid/graphics/Region;)V");
			global::android.graphics.Region._Region5769 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "<init>", "(Landroid/graphics/Rect;)V");
			global::android.graphics.Region._Region5770 = @__env.GetMethodIDNoThrow(global::android.graphics.Region.staticClass, "<init>", "(IIII)V");
			global::android.graphics.Region._CREATOR5771 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Region.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
