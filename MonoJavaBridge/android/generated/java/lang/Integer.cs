namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Integer : java.lang.Number, Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Integer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _numberOfLeadingZeros20195;
		public static int numberOfLeadingZeros(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._numberOfLeadingZeros20195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _numberOfTrailingZeros20196;
		public static int numberOfTrailingZeros(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._numberOfTrailingZeros20196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bitCount20197;
		public static int bitCount(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._bitCount20197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals20198;
		public sealed override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Integer._equals20198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._equals20198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString20199;
		public static global::java.lang.String toString(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._toString20199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString20200;
		public static global::java.lang.String toString(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._toString20200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString20201;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Integer._toString20201)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._toString20201)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20202;
		public sealed override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Integer._hashCode20202);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._hashCode20202);
		}
		internal static global::MonoJavaBridge.MethodId _reverseBytes20203;
		public static int reverseBytes(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._reverseBytes20203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo20204;
		public int compareTo(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Integer._compareTo20204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._compareTo20204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo20205;
		public int compareTo(java.lang.Integer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Integer._compareTo20205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._compareTo20205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toHexString20206;
		public static global::java.lang.String toHexString(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._toHexString20206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf20207;
		public static global::java.lang.Integer valueOf(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Integer>(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._valueOf20207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Integer;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf20208;
		public static global::java.lang.Integer valueOf(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Integer>(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._valueOf20208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Integer;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf20209;
		public static global::java.lang.Integer valueOf(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Integer>(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._valueOf20209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Integer;
		}
		internal static global::MonoJavaBridge.MethodId _decode20210;
		public static global::java.lang.Integer decode(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Integer>(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._decode20210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Integer;
		}
		internal static global::MonoJavaBridge.MethodId _reverse20211;
		public static int reverse(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._reverse20211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _byteValue20212;
		public sealed override byte byteValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.lang.Integer._byteValue20212);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._byteValue20212);
		}
		internal static global::MonoJavaBridge.MethodId _shortValue20213;
		public sealed override short shortValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.lang.Integer._shortValue20213);
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._shortValue20213);
		}
		internal static global::MonoJavaBridge.MethodId _intValue20214;
		public sealed override int intValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Integer._intValue20214);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._intValue20214);
		}
		internal static global::MonoJavaBridge.MethodId _longValue20215;
		public sealed override long longValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.lang.Integer._longValue20215);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._longValue20215);
		}
		internal static global::MonoJavaBridge.MethodId _floatValue20216;
		public sealed override float floatValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.lang.Integer._floatValue20216);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._floatValue20216);
		}
		internal static global::MonoJavaBridge.MethodId _doubleValue20217;
		public sealed override double doubleValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.lang.Integer._doubleValue20217);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.lang.Integer.staticClass, global::java.lang.Integer._doubleValue20217);
		}
		internal static global::MonoJavaBridge.MethodId _parseInt20218;
		public static int parseInt(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._parseInt20218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parseInt20219;
		public static int parseInt(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._parseInt20219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _toOctalString20220;
		public static global::java.lang.String toOctalString(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._toOctalString20220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toBinaryString20221;
		public static global::java.lang.String toBinaryString(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._toBinaryString20221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getInteger20222;
		public static global::java.lang.Integer getInteger(java.lang.String arg0, java.lang.Integer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Integer>(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._getInteger20222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Integer;
		}
		internal static global::MonoJavaBridge.MethodId _getInteger20223;
		public static global::java.lang.Integer getInteger(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Integer>(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._getInteger20223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Integer;
		}
		internal static global::MonoJavaBridge.MethodId _getInteger20224;
		public static global::java.lang.Integer getInteger(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Integer>(@__env.CallStaticObjectMethod(java.lang.Integer.staticClass, global::java.lang.Integer._getInteger20224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Integer;
		}
		internal static global::MonoJavaBridge.MethodId _highestOneBit20225;
		public static int highestOneBit(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._highestOneBit20225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _lowestOneBit20226;
		public static int lowestOneBit(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._lowestOneBit20226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _rotateLeft20227;
		public static int rotateLeft(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._rotateLeft20227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _rotateRight20228;
		public static int rotateRight(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._rotateRight20228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _signum20229;
		public static int signum(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Integer.staticClass, global::java.lang.Integer._signum20229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Integer20230;
		public Integer(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Integer.staticClass, global::java.lang.Integer._Integer20230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Integer20231;
		public Integer(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Integer.staticClass, global::java.lang.Integer._Integer20231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static int MIN_VALUE
		{
			get
			{
				return -2147483648;
			}
		}
		public static int MAX_VALUE
		{
			get
			{
				return 2147483647;
			}
		}
		internal static global::MonoJavaBridge.FieldId _TYPE20234;
		public static global::java.lang.Class TYPE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.GetStaticObjectField(global::java.lang.Integer.staticClass, _TYPE20234)) as java.lang.Class;
			}
		}
		public static int SIZE
		{
			get
			{
				return 32;
			}
		}
		static Integer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Integer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Integer"));
			global::java.lang.Integer._numberOfLeadingZeros20195 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "numberOfLeadingZeros", "(I)I");
			global::java.lang.Integer._numberOfTrailingZeros20196 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "numberOfTrailingZeros", "(I)I");
			global::java.lang.Integer._bitCount20197 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "bitCount", "(I)I");
			global::java.lang.Integer._equals20198 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.Integer._toString20199 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "toString", "(II)Ljava/lang/String;");
			global::java.lang.Integer._toString20200 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "toString", "(I)Ljava/lang/String;");
			global::java.lang.Integer._toString20201 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Integer._hashCode20202 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "hashCode", "()I");
			global::java.lang.Integer._reverseBytes20203 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "reverseBytes", "(I)I");
			global::java.lang.Integer._compareTo20204 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.lang.Integer._compareTo20205 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "compareTo", "(Ljava/lang/Integer;)I");
			global::java.lang.Integer._toHexString20206 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "toHexString", "(I)Ljava/lang/String;");
			global::java.lang.Integer._valueOf20207 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "valueOf", "(Ljava/lang/String;I)Ljava/lang/Integer;");
			global::java.lang.Integer._valueOf20208 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Integer;");
			global::java.lang.Integer._valueOf20209 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "valueOf", "(I)Ljava/lang/Integer;");
			global::java.lang.Integer._decode20210 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "decode", "(Ljava/lang/String;)Ljava/lang/Integer;");
			global::java.lang.Integer._reverse20211 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "reverse", "(I)I");
			global::java.lang.Integer._byteValue20212 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "byteValue", "()B");
			global::java.lang.Integer._shortValue20213 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "shortValue", "()S");
			global::java.lang.Integer._intValue20214 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "intValue", "()I");
			global::java.lang.Integer._longValue20215 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "longValue", "()J");
			global::java.lang.Integer._floatValue20216 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "floatValue", "()F");
			global::java.lang.Integer._doubleValue20217 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "doubleValue", "()D");
			global::java.lang.Integer._parseInt20218 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "parseInt", "(Ljava/lang/String;)I");
			global::java.lang.Integer._parseInt20219 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "parseInt", "(Ljava/lang/String;I)I");
			global::java.lang.Integer._toOctalString20220 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "toOctalString", "(I)Ljava/lang/String;");
			global::java.lang.Integer._toBinaryString20221 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "toBinaryString", "(I)Ljava/lang/String;");
			global::java.lang.Integer._getInteger20222 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "getInteger", "(Ljava/lang/String;Ljava/lang/Integer;)Ljava/lang/Integer;");
			global::java.lang.Integer._getInteger20223 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "getInteger", "(Ljava/lang/String;)Ljava/lang/Integer;");
			global::java.lang.Integer._getInteger20224 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "getInteger", "(Ljava/lang/String;I)Ljava/lang/Integer;");
			global::java.lang.Integer._highestOneBit20225 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "highestOneBit", "(I)I");
			global::java.lang.Integer._lowestOneBit20226 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "lowestOneBit", "(I)I");
			global::java.lang.Integer._rotateLeft20227 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "rotateLeft", "(II)I");
			global::java.lang.Integer._rotateRight20228 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "rotateRight", "(II)I");
			global::java.lang.Integer._signum20229 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Integer.staticClass, "signum", "(I)I");
			global::java.lang.Integer._Integer20230 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "<init>", "(I)V");
			global::java.lang.Integer._Integer20231 = @__env.GetMethodIDNoThrow(global::java.lang.Integer.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.Integer._TYPE20234 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Integer.staticClass, "TYPE", "Ljava/lang/Class;");
		}
		internal static void InitJNI()
		{
		}
	}
}
