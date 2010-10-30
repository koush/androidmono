namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class ContentValues : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ContentValues(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get2775;
		public global::java.lang.Object get(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.ContentValues.staticClass, "get", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::android.content.ContentValues._get2775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put2776;
		public void put(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::android.content.ContentValues._put2776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _put2777;
		public void put(java.lang.String arg0, java.lang.Byte arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Byte;)V", ref global::android.content.ContentValues._put2777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _put2778;
		public void put(java.lang.String arg0, java.lang.Short arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Short;)V", ref global::android.content.ContentValues._put2778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _put2779;
		public void put(java.lang.String arg0, java.lang.Integer arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Integer;)V", ref global::android.content.ContentValues._put2779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _put2780;
		public void put(java.lang.String arg0, java.lang.Long arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Long;)V", ref global::android.content.ContentValues._put2780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _put2781;
		public void put(java.lang.String arg0, java.lang.Boolean arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Boolean;)V", ref global::android.content.ContentValues._put2781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _put2782;
		public void put(java.lang.String arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;[B)V", ref global::android.content.ContentValues._put2782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _put2783;
		public void put(java.lang.String arg0, java.lang.Float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Float;)V", ref global::android.content.ContentValues._put2783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _put2784;
		public void put(java.lang.String arg0, java.lang.Double arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentValues.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Double;)V", ref global::android.content.ContentValues._put2784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _equals2785;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.ContentValues.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.content.ContentValues._equals2785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString2786;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.ContentValues.staticClass, "toString", "()Ljava/lang/String;", ref global::android.content.ContentValues._toString2786) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode2787;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.ContentValues.staticClass, "hashCode", "()I", ref global::android.content.ContentValues._hashCode2787);
		}
		internal static global::MonoJavaBridge.MethodId _clear2788;
		public void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentValues.staticClass, "clear", "()V", ref global::android.content.ContentValues._clear2788);
		}
		internal static global::MonoJavaBridge.MethodId _size2789;
		public int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.ContentValues.staticClass, "size", "()I", ref global::android.content.ContentValues._size2789);
		}
		internal static global::MonoJavaBridge.MethodId _putAll2790;
		public void putAll(android.content.ContentValues arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentValues.staticClass, "putAll", "(Landroid/content/ContentValues;)V", ref global::android.content.ContentValues._putAll2790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove2791;
		public void remove(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentValues.staticClass, "remove", "(Ljava/lang/String;)V", ref global::android.content.ContentValues._remove2791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsKey2792;
		public bool containsKey(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.ContentValues.staticClass, "containsKey", "(Ljava/lang/String;)Z", ref global::android.content.ContentValues._containsKey2792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAsString2793;
		public global::java.lang.String getAsString(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.ContentValues.staticClass, "getAsString", "(Ljava/lang/String;)Ljava/lang/String;", ref global::android.content.ContentValues._getAsString2793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _putNull2794;
		public void putNull(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentValues.staticClass, "putNull", "(Ljava/lang/String;)V", ref global::android.content.ContentValues._putNull2794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel2795;
		public void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.ContentValues.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.content.ContentValues._writeToParcel2795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents2796;
		public int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.ContentValues.staticClass, "describeContents", "()I", ref global::android.content.ContentValues._describeContents2796);
		}
		internal static global::MonoJavaBridge.MethodId _getAsLong2797;
		public global::java.lang.Long getAsLong(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Long>(this, global::android.content.ContentValues.staticClass, "getAsLong", "(Ljava/lang/String;)Ljava/lang/Long;", ref global::android.content.ContentValues._getAsLong2797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Long;
		}
		internal static global::MonoJavaBridge.MethodId _getAsInteger2798;
		public global::java.lang.Integer getAsInteger(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Integer>(this, global::android.content.ContentValues.staticClass, "getAsInteger", "(Ljava/lang/String;)Ljava/lang/Integer;", ref global::android.content.ContentValues._getAsInteger2798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Integer;
		}
		internal static global::MonoJavaBridge.MethodId _getAsShort2799;
		public global::java.lang.Short getAsShort(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Short>(this, global::android.content.ContentValues.staticClass, "getAsShort", "(Ljava/lang/String;)Ljava/lang/Short;", ref global::android.content.ContentValues._getAsShort2799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Short;
		}
		internal static global::MonoJavaBridge.MethodId _getAsByte2800;
		public global::java.lang.Byte getAsByte(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Byte>(this, global::android.content.ContentValues.staticClass, "getAsByte", "(Ljava/lang/String;)Ljava/lang/Byte;", ref global::android.content.ContentValues._getAsByte2800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Byte;
		}
		internal static global::MonoJavaBridge.MethodId _getAsDouble2801;
		public global::java.lang.Double getAsDouble(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Double>(this, global::android.content.ContentValues.staticClass, "getAsDouble", "(Ljava/lang/String;)Ljava/lang/Double;", ref global::android.content.ContentValues._getAsDouble2801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Double;
		}
		internal static global::MonoJavaBridge.MethodId _getAsFloat2802;
		public global::java.lang.Float getAsFloat(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Float>(this, global::android.content.ContentValues.staticClass, "getAsFloat", "(Ljava/lang/String;)Ljava/lang/Float;", ref global::android.content.ContentValues._getAsFloat2802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Float;
		}
		internal static global::MonoJavaBridge.MethodId _getAsBoolean2803;
		public global::java.lang.Boolean getAsBoolean(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Boolean>(this, global::android.content.ContentValues.staticClass, "getAsBoolean", "(Ljava/lang/String;)Ljava/lang/Boolean;", ref global::android.content.ContentValues._getAsBoolean2803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Boolean;
		}
		internal static global::MonoJavaBridge.MethodId _getAsByteArray2804;
		public byte[] getAsByteArray(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::android.content.ContentValues.staticClass, "getAsByteArray", "(Ljava/lang/String;)[B", ref global::android.content.ContentValues._getAsByteArray2804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _valueSet2805;
		public global::java.util.Set valueSet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::android.content.ContentValues.staticClass, "valueSet", "()Ljava/util/Set;", ref global::android.content.ContentValues._valueSet2805) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _ContentValues2806;
		public ContentValues() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ContentValues._ContentValues2806.native == global::System.IntPtr.Zero)
				global::android.content.ContentValues._ContentValues2806 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ContentValues.staticClass, global::android.content.ContentValues._ContentValues2806);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ContentValues2807;
		public ContentValues(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ContentValues._ContentValues2807.native == global::System.IntPtr.Zero)
				global::android.content.ContentValues._ContentValues2807 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ContentValues.staticClass, global::android.content.ContentValues._ContentValues2807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ContentValues2808;
		public ContentValues(android.content.ContentValues arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ContentValues._ContentValues2808.native == global::System.IntPtr.Zero)
				global::android.content.ContentValues._ContentValues2808 = @__env.GetMethodIDNoThrow(global::android.content.ContentValues.staticClass, "<init>", "(Landroid/content/ContentValues;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ContentValues.staticClass, global::android.content.ContentValues._ContentValues2808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static global::java.lang.String TAG
		{
			get
			{
				return "ContentValues";
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2810;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.ContentValues.staticClass, _CREATOR2810)) as android.os.Parcelable_Creator;
			}
		}
		static ContentValues()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.ContentValues.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ContentValues"));
			global::android.content.ContentValues._CREATOR2810 = @__env.GetStaticFieldIDNoThrow(global::android.content.ContentValues.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
