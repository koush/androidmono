namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Character : java.lang.Object, java.io.Serializable, Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Character(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Subset : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected Subset(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public sealed override bool equals(java.lang.Object arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Character.Subset.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.lang.Character.Subset._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public sealed override global::java.lang.String toString()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.Character.Subset.staticClass, "toString", "()Ljava/lang/String;", ref global::java.lang.Character.Subset._m1) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public sealed override int hashCode()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Character.Subset.staticClass, "hashCode", "()I", ref global::java.lang.Character.Subset._m2);
			}
			private static global::MonoJavaBridge.MethodId _m3;
			protected Subset(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.lang.Character.Subset._m3.native == global::System.IntPtr.Zero)
					global::java.lang.Character.Subset._m3 = @__env.GetMethodIDNoThrow(global::java.lang.Character.Subset.staticClass, "<init>", "(Ljava/lang/String;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Character.Subset.staticClass, global::java.lang.Character.Subset._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static Subset()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.lang.Character.Subset.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Character$Subset"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class UnicodeBlock : java.lang.Character.Subset
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal UnicodeBlock(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::java.lang.Character.UnicodeBlock forName(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.lang.Character.UnicodeBlock._m0.native == global::System.IntPtr.Zero)
					global::java.lang.Character.UnicodeBlock._m0 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "forName", "(Ljava/lang/String;)Ljava/lang/Character$UnicodeBlock;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.CallStaticObjectMethod(java.lang.Character.UnicodeBlock.staticClass, global::java.lang.Character.UnicodeBlock._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Character.UnicodeBlock;
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::java.lang.Character.UnicodeBlock of(char arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.lang.Character.UnicodeBlock._m1.native == global::System.IntPtr.Zero)
					global::java.lang.Character.UnicodeBlock._m1 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "of", "(C)Ljava/lang/Character$UnicodeBlock;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.CallStaticObjectMethod(java.lang.Character.UnicodeBlock.staticClass, global::java.lang.Character.UnicodeBlock._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Character.UnicodeBlock;
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public static global::java.lang.Character.UnicodeBlock of(int arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.lang.Character.UnicodeBlock._m2.native == global::System.IntPtr.Zero)
					global::java.lang.Character.UnicodeBlock._m2 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "of", "(I)Ljava/lang/Character$UnicodeBlock;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.CallStaticObjectMethod(java.lang.Character.UnicodeBlock.staticClass, global::java.lang.Character.UnicodeBlock._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Character.UnicodeBlock;
			}
			internal static global::MonoJavaBridge.FieldId _BASIC_LATIN6244;
			public static global::java.lang.Character.UnicodeBlock BASIC_LATIN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _BASIC_LATIN6244)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LATIN_1_SUPPLEMENT6245;
			public static global::java.lang.Character.UnicodeBlock LATIN_1_SUPPLEMENT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _LATIN_1_SUPPLEMENT6245)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LATIN_EXTENDED_A6246;
			public static global::java.lang.Character.UnicodeBlock LATIN_EXTENDED_A
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _LATIN_EXTENDED_A6246)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LATIN_EXTENDED_B6247;
			public static global::java.lang.Character.UnicodeBlock LATIN_EXTENDED_B
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _LATIN_EXTENDED_B6247)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _IPA_EXTENSIONS6248;
			public static global::java.lang.Character.UnicodeBlock IPA_EXTENSIONS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _IPA_EXTENSIONS6248)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SPACING_MODIFIER_LETTERS6249;
			public static global::java.lang.Character.UnicodeBlock SPACING_MODIFIER_LETTERS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _SPACING_MODIFIER_LETTERS6249)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _COMBINING_DIACRITICAL_MARKS6250;
			public static global::java.lang.Character.UnicodeBlock COMBINING_DIACRITICAL_MARKS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _COMBINING_DIACRITICAL_MARKS6250)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _GREEK6251;
			public static global::java.lang.Character.UnicodeBlock GREEK
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _GREEK6251)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CYRILLIC6252;
			public static global::java.lang.Character.UnicodeBlock CYRILLIC
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CYRILLIC6252)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ARMENIAN6253;
			public static global::java.lang.Character.UnicodeBlock ARMENIAN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _ARMENIAN6253)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _HEBREW6254;
			public static global::java.lang.Character.UnicodeBlock HEBREW
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _HEBREW6254)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ARABIC6255;
			public static global::java.lang.Character.UnicodeBlock ARABIC
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _ARABIC6255)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DEVANAGARI6256;
			public static global::java.lang.Character.UnicodeBlock DEVANAGARI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _DEVANAGARI6256)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _BENGALI6257;
			public static global::java.lang.Character.UnicodeBlock BENGALI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _BENGALI6257)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _GURMUKHI6258;
			public static global::java.lang.Character.UnicodeBlock GURMUKHI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _GURMUKHI6258)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _GUJARATI6259;
			public static global::java.lang.Character.UnicodeBlock GUJARATI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _GUJARATI6259)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ORIYA6260;
			public static global::java.lang.Character.UnicodeBlock ORIYA
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _ORIYA6260)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TAMIL6261;
			public static global::java.lang.Character.UnicodeBlock TAMIL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _TAMIL6261)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TELUGU6262;
			public static global::java.lang.Character.UnicodeBlock TELUGU
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _TELUGU6262)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _KANNADA6263;
			public static global::java.lang.Character.UnicodeBlock KANNADA
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _KANNADA6263)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MALAYALAM6264;
			public static global::java.lang.Character.UnicodeBlock MALAYALAM
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _MALAYALAM6264)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _THAI6265;
			public static global::java.lang.Character.UnicodeBlock THAI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _THAI6265)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LAO6266;
			public static global::java.lang.Character.UnicodeBlock LAO
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _LAO6266)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TIBETAN6267;
			public static global::java.lang.Character.UnicodeBlock TIBETAN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _TIBETAN6267)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _GEORGIAN6268;
			public static global::java.lang.Character.UnicodeBlock GEORGIAN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _GEORGIAN6268)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _HANGUL_JAMO6269;
			public static global::java.lang.Character.UnicodeBlock HANGUL_JAMO
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _HANGUL_JAMO6269)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LATIN_EXTENDED_ADDITIONAL6270;
			public static global::java.lang.Character.UnicodeBlock LATIN_EXTENDED_ADDITIONAL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _LATIN_EXTENDED_ADDITIONAL6270)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _GREEK_EXTENDED6271;
			public static global::java.lang.Character.UnicodeBlock GREEK_EXTENDED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _GREEK_EXTENDED6271)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _GENERAL_PUNCTUATION6272;
			public static global::java.lang.Character.UnicodeBlock GENERAL_PUNCTUATION
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _GENERAL_PUNCTUATION6272)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SUPERSCRIPTS_AND_SUBSCRIPTS6273;
			public static global::java.lang.Character.UnicodeBlock SUPERSCRIPTS_AND_SUBSCRIPTS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _SUPERSCRIPTS_AND_SUBSCRIPTS6273)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CURRENCY_SYMBOLS6274;
			public static global::java.lang.Character.UnicodeBlock CURRENCY_SYMBOLS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CURRENCY_SYMBOLS6274)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _COMBINING_MARKS_FOR_SYMBOLS6275;
			public static global::java.lang.Character.UnicodeBlock COMBINING_MARKS_FOR_SYMBOLS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _COMBINING_MARKS_FOR_SYMBOLS6275)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LETTERLIKE_SYMBOLS6276;
			public static global::java.lang.Character.UnicodeBlock LETTERLIKE_SYMBOLS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _LETTERLIKE_SYMBOLS6276)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _NUMBER_FORMS6277;
			public static global::java.lang.Character.UnicodeBlock NUMBER_FORMS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _NUMBER_FORMS6277)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ARROWS6278;
			public static global::java.lang.Character.UnicodeBlock ARROWS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _ARROWS6278)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MATHEMATICAL_OPERATORS6279;
			public static global::java.lang.Character.UnicodeBlock MATHEMATICAL_OPERATORS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _MATHEMATICAL_OPERATORS6279)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MISCELLANEOUS_TECHNICAL6280;
			public static global::java.lang.Character.UnicodeBlock MISCELLANEOUS_TECHNICAL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _MISCELLANEOUS_TECHNICAL6280)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CONTROL_PICTURES6281;
			public static global::java.lang.Character.UnicodeBlock CONTROL_PICTURES
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CONTROL_PICTURES6281)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _OPTICAL_CHARACTER_RECOGNITION6282;
			public static global::java.lang.Character.UnicodeBlock OPTICAL_CHARACTER_RECOGNITION
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _OPTICAL_CHARACTER_RECOGNITION6282)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ENCLOSED_ALPHANUMERICS6283;
			public static global::java.lang.Character.UnicodeBlock ENCLOSED_ALPHANUMERICS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _ENCLOSED_ALPHANUMERICS6283)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _BOX_DRAWING6284;
			public static global::java.lang.Character.UnicodeBlock BOX_DRAWING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _BOX_DRAWING6284)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _BLOCK_ELEMENTS6285;
			public static global::java.lang.Character.UnicodeBlock BLOCK_ELEMENTS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _BLOCK_ELEMENTS6285)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _GEOMETRIC_SHAPES6286;
			public static global::java.lang.Character.UnicodeBlock GEOMETRIC_SHAPES
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _GEOMETRIC_SHAPES6286)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MISCELLANEOUS_SYMBOLS6287;
			public static global::java.lang.Character.UnicodeBlock MISCELLANEOUS_SYMBOLS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _MISCELLANEOUS_SYMBOLS6287)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DINGBATS6288;
			public static global::java.lang.Character.UnicodeBlock DINGBATS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _DINGBATS6288)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CJK_SYMBOLS_AND_PUNCTUATION6289;
			public static global::java.lang.Character.UnicodeBlock CJK_SYMBOLS_AND_PUNCTUATION
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CJK_SYMBOLS_AND_PUNCTUATION6289)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _HIRAGANA6290;
			public static global::java.lang.Character.UnicodeBlock HIRAGANA
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _HIRAGANA6290)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _KATAKANA6291;
			public static global::java.lang.Character.UnicodeBlock KATAKANA
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _KATAKANA6291)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _BOPOMOFO6292;
			public static global::java.lang.Character.UnicodeBlock BOPOMOFO
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _BOPOMOFO6292)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _HANGUL_COMPATIBILITY_JAMO6293;
			public static global::java.lang.Character.UnicodeBlock HANGUL_COMPATIBILITY_JAMO
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _HANGUL_COMPATIBILITY_JAMO6293)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _KANBUN6294;
			public static global::java.lang.Character.UnicodeBlock KANBUN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _KANBUN6294)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ENCLOSED_CJK_LETTERS_AND_MONTHS6295;
			public static global::java.lang.Character.UnicodeBlock ENCLOSED_CJK_LETTERS_AND_MONTHS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _ENCLOSED_CJK_LETTERS_AND_MONTHS6295)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CJK_COMPATIBILITY6296;
			public static global::java.lang.Character.UnicodeBlock CJK_COMPATIBILITY
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CJK_COMPATIBILITY6296)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CJK_UNIFIED_IDEOGRAPHS6297;
			public static global::java.lang.Character.UnicodeBlock CJK_UNIFIED_IDEOGRAPHS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CJK_UNIFIED_IDEOGRAPHS6297)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _HANGUL_SYLLABLES6298;
			public static global::java.lang.Character.UnicodeBlock HANGUL_SYLLABLES
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _HANGUL_SYLLABLES6298)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _PRIVATE_USE_AREA6299;
			public static global::java.lang.Character.UnicodeBlock PRIVATE_USE_AREA
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _PRIVATE_USE_AREA6299)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CJK_COMPATIBILITY_IDEOGRAPHS6300;
			public static global::java.lang.Character.UnicodeBlock CJK_COMPATIBILITY_IDEOGRAPHS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CJK_COMPATIBILITY_IDEOGRAPHS6300)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ALPHABETIC_PRESENTATION_FORMS6301;
			public static global::java.lang.Character.UnicodeBlock ALPHABETIC_PRESENTATION_FORMS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _ALPHABETIC_PRESENTATION_FORMS6301)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ARABIC_PRESENTATION_FORMS_A6302;
			public static global::java.lang.Character.UnicodeBlock ARABIC_PRESENTATION_FORMS_A
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _ARABIC_PRESENTATION_FORMS_A6302)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _COMBINING_HALF_MARKS6303;
			public static global::java.lang.Character.UnicodeBlock COMBINING_HALF_MARKS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _COMBINING_HALF_MARKS6303)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CJK_COMPATIBILITY_FORMS6304;
			public static global::java.lang.Character.UnicodeBlock CJK_COMPATIBILITY_FORMS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CJK_COMPATIBILITY_FORMS6304)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SMALL_FORM_VARIANTS6305;
			public static global::java.lang.Character.UnicodeBlock SMALL_FORM_VARIANTS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _SMALL_FORM_VARIANTS6305)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ARABIC_PRESENTATION_FORMS_B6306;
			public static global::java.lang.Character.UnicodeBlock ARABIC_PRESENTATION_FORMS_B
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _ARABIC_PRESENTATION_FORMS_B6306)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _HALFWIDTH_AND_FULLWIDTH_FORMS6307;
			public static global::java.lang.Character.UnicodeBlock HALFWIDTH_AND_FULLWIDTH_FORMS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _HALFWIDTH_AND_FULLWIDTH_FORMS6307)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SPECIALS6308;
			public static global::java.lang.Character.UnicodeBlock SPECIALS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _SPECIALS6308)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SURROGATES_AREA6309;
			public static global::java.lang.Character.UnicodeBlock SURROGATES_AREA
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _SURROGATES_AREA6309)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SYRIAC6310;
			public static global::java.lang.Character.UnicodeBlock SYRIAC
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _SYRIAC6310)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _THAANA6311;
			public static global::java.lang.Character.UnicodeBlock THAANA
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _THAANA6311)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SINHALA6312;
			public static global::java.lang.Character.UnicodeBlock SINHALA
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _SINHALA6312)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MYANMAR6313;
			public static global::java.lang.Character.UnicodeBlock MYANMAR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _MYANMAR6313)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ETHIOPIC6314;
			public static global::java.lang.Character.UnicodeBlock ETHIOPIC
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _ETHIOPIC6314)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CHEROKEE6315;
			public static global::java.lang.Character.UnicodeBlock CHEROKEE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CHEROKEE6315)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _UNIFIED_CANADIAN_ABORIGINAL_SYLLABICS6316;
			public static global::java.lang.Character.UnicodeBlock UNIFIED_CANADIAN_ABORIGINAL_SYLLABICS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _UNIFIED_CANADIAN_ABORIGINAL_SYLLABICS6316)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _OGHAM6317;
			public static global::java.lang.Character.UnicodeBlock OGHAM
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _OGHAM6317)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _RUNIC6318;
			public static global::java.lang.Character.UnicodeBlock RUNIC
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _RUNIC6318)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _KHMER6319;
			public static global::java.lang.Character.UnicodeBlock KHMER
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _KHMER6319)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MONGOLIAN6320;
			public static global::java.lang.Character.UnicodeBlock MONGOLIAN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _MONGOLIAN6320)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _BRAILLE_PATTERNS6321;
			public static global::java.lang.Character.UnicodeBlock BRAILLE_PATTERNS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _BRAILLE_PATTERNS6321)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CJK_RADICALS_SUPPLEMENT6322;
			public static global::java.lang.Character.UnicodeBlock CJK_RADICALS_SUPPLEMENT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CJK_RADICALS_SUPPLEMENT6322)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _KANGXI_RADICALS6323;
			public static global::java.lang.Character.UnicodeBlock KANGXI_RADICALS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _KANGXI_RADICALS6323)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _IDEOGRAPHIC_DESCRIPTION_CHARACTERS6324;
			public static global::java.lang.Character.UnicodeBlock IDEOGRAPHIC_DESCRIPTION_CHARACTERS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _IDEOGRAPHIC_DESCRIPTION_CHARACTERS6324)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _BOPOMOFO_EXTENDED6325;
			public static global::java.lang.Character.UnicodeBlock BOPOMOFO_EXTENDED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _BOPOMOFO_EXTENDED6325)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CJK_UNIFIED_IDEOGRAPHS_EXTENSION_A6326;
			public static global::java.lang.Character.UnicodeBlock CJK_UNIFIED_IDEOGRAPHS_EXTENSION_A
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CJK_UNIFIED_IDEOGRAPHS_EXTENSION_A6326)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _YI_SYLLABLES6327;
			public static global::java.lang.Character.UnicodeBlock YI_SYLLABLES
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _YI_SYLLABLES6327)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _YI_RADICALS6328;
			public static global::java.lang.Character.UnicodeBlock YI_RADICALS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _YI_RADICALS6328)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CYRILLIC_SUPPLEMENTARY6329;
			public static global::java.lang.Character.UnicodeBlock CYRILLIC_SUPPLEMENTARY
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CYRILLIC_SUPPLEMENTARY6329)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TAGALOG6330;
			public static global::java.lang.Character.UnicodeBlock TAGALOG
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _TAGALOG6330)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _HANUNOO6331;
			public static global::java.lang.Character.UnicodeBlock HANUNOO
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _HANUNOO6331)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _BUHID6332;
			public static global::java.lang.Character.UnicodeBlock BUHID
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _BUHID6332)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TAGBANWA6333;
			public static global::java.lang.Character.UnicodeBlock TAGBANWA
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _TAGBANWA6333)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LIMBU6334;
			public static global::java.lang.Character.UnicodeBlock LIMBU
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _LIMBU6334)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TAI_LE6335;
			public static global::java.lang.Character.UnicodeBlock TAI_LE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _TAI_LE6335)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _KHMER_SYMBOLS6336;
			public static global::java.lang.Character.UnicodeBlock KHMER_SYMBOLS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _KHMER_SYMBOLS6336)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _PHONETIC_EXTENSIONS6337;
			public static global::java.lang.Character.UnicodeBlock PHONETIC_EXTENSIONS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _PHONETIC_EXTENSIONS6337)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MISCELLANEOUS_MATHEMATICAL_SYMBOLS_A6338;
			public static global::java.lang.Character.UnicodeBlock MISCELLANEOUS_MATHEMATICAL_SYMBOLS_A
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _MISCELLANEOUS_MATHEMATICAL_SYMBOLS_A6338)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SUPPLEMENTAL_ARROWS_A6339;
			public static global::java.lang.Character.UnicodeBlock SUPPLEMENTAL_ARROWS_A
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _SUPPLEMENTAL_ARROWS_A6339)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SUPPLEMENTAL_ARROWS_B6340;
			public static global::java.lang.Character.UnicodeBlock SUPPLEMENTAL_ARROWS_B
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _SUPPLEMENTAL_ARROWS_B6340)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MISCELLANEOUS_MATHEMATICAL_SYMBOLS_B6341;
			public static global::java.lang.Character.UnicodeBlock MISCELLANEOUS_MATHEMATICAL_SYMBOLS_B
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _MISCELLANEOUS_MATHEMATICAL_SYMBOLS_B6341)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SUPPLEMENTAL_MATHEMATICAL_OPERATORS6342;
			public static global::java.lang.Character.UnicodeBlock SUPPLEMENTAL_MATHEMATICAL_OPERATORS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _SUPPLEMENTAL_MATHEMATICAL_OPERATORS6342)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MISCELLANEOUS_SYMBOLS_AND_ARROWS6343;
			public static global::java.lang.Character.UnicodeBlock MISCELLANEOUS_SYMBOLS_AND_ARROWS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _MISCELLANEOUS_SYMBOLS_AND_ARROWS6343)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _KATAKANA_PHONETIC_EXTENSIONS6344;
			public static global::java.lang.Character.UnicodeBlock KATAKANA_PHONETIC_EXTENSIONS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _KATAKANA_PHONETIC_EXTENSIONS6344)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _YIJING_HEXAGRAM_SYMBOLS6345;
			public static global::java.lang.Character.UnicodeBlock YIJING_HEXAGRAM_SYMBOLS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _YIJING_HEXAGRAM_SYMBOLS6345)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _VARIATION_SELECTORS6346;
			public static global::java.lang.Character.UnicodeBlock VARIATION_SELECTORS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _VARIATION_SELECTORS6346)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LINEAR_B_SYLLABARY6347;
			public static global::java.lang.Character.UnicodeBlock LINEAR_B_SYLLABARY
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _LINEAR_B_SYLLABARY6347)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LINEAR_B_IDEOGRAMS6348;
			public static global::java.lang.Character.UnicodeBlock LINEAR_B_IDEOGRAMS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _LINEAR_B_IDEOGRAMS6348)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _AEGEAN_NUMBERS6349;
			public static global::java.lang.Character.UnicodeBlock AEGEAN_NUMBERS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _AEGEAN_NUMBERS6349)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _OLD_ITALIC6350;
			public static global::java.lang.Character.UnicodeBlock OLD_ITALIC
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _OLD_ITALIC6350)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _GOTHIC6351;
			public static global::java.lang.Character.UnicodeBlock GOTHIC
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _GOTHIC6351)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _UGARITIC6352;
			public static global::java.lang.Character.UnicodeBlock UGARITIC
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _UGARITIC6352)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DESERET6353;
			public static global::java.lang.Character.UnicodeBlock DESERET
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _DESERET6353)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SHAVIAN6354;
			public static global::java.lang.Character.UnicodeBlock SHAVIAN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _SHAVIAN6354)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _OSMANYA6355;
			public static global::java.lang.Character.UnicodeBlock OSMANYA
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _OSMANYA6355)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CYPRIOT_SYLLABARY6356;
			public static global::java.lang.Character.UnicodeBlock CYPRIOT_SYLLABARY
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CYPRIOT_SYLLABARY6356)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _BYZANTINE_MUSICAL_SYMBOLS6357;
			public static global::java.lang.Character.UnicodeBlock BYZANTINE_MUSICAL_SYMBOLS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _BYZANTINE_MUSICAL_SYMBOLS6357)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MUSICAL_SYMBOLS6358;
			public static global::java.lang.Character.UnicodeBlock MUSICAL_SYMBOLS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _MUSICAL_SYMBOLS6358)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TAI_XUAN_JING_SYMBOLS6359;
			public static global::java.lang.Character.UnicodeBlock TAI_XUAN_JING_SYMBOLS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _TAI_XUAN_JING_SYMBOLS6359)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MATHEMATICAL_ALPHANUMERIC_SYMBOLS6360;
			public static global::java.lang.Character.UnicodeBlock MATHEMATICAL_ALPHANUMERIC_SYMBOLS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _MATHEMATICAL_ALPHANUMERIC_SYMBOLS6360)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CJK_UNIFIED_IDEOGRAPHS_EXTENSION_B6361;
			public static global::java.lang.Character.UnicodeBlock CJK_UNIFIED_IDEOGRAPHS_EXTENSION_B
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CJK_UNIFIED_IDEOGRAPHS_EXTENSION_B6361)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CJK_COMPATIBILITY_IDEOGRAPHS_SUPPLEMENT6362;
			public static global::java.lang.Character.UnicodeBlock CJK_COMPATIBILITY_IDEOGRAPHS_SUPPLEMENT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CJK_COMPATIBILITY_IDEOGRAPHS_SUPPLEMENT6362)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TAGS6363;
			public static global::java.lang.Character.UnicodeBlock TAGS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _TAGS6363)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _VARIATION_SELECTORS_SUPPLEMENT6364;
			public static global::java.lang.Character.UnicodeBlock VARIATION_SELECTORS_SUPPLEMENT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _VARIATION_SELECTORS_SUPPLEMENT6364)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SUPPLEMENTARY_PRIVATE_USE_AREA_A6365;
			public static global::java.lang.Character.UnicodeBlock SUPPLEMENTARY_PRIVATE_USE_AREA_A
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _SUPPLEMENTARY_PRIVATE_USE_AREA_A6365)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SUPPLEMENTARY_PRIVATE_USE_AREA_B6366;
			public static global::java.lang.Character.UnicodeBlock SUPPLEMENTARY_PRIVATE_USE_AREA_B
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _SUPPLEMENTARY_PRIVATE_USE_AREA_B6366)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _HIGH_SURROGATES6367;
			public static global::java.lang.Character.UnicodeBlock HIGH_SURROGATES
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _HIGH_SURROGATES6367)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _HIGH_PRIVATE_USE_SURROGATES6368;
			public static global::java.lang.Character.UnicodeBlock HIGH_PRIVATE_USE_SURROGATES
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _HIGH_PRIVATE_USE_SURROGATES6368)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LOW_SURROGATES6369;
			public static global::java.lang.Character.UnicodeBlock LOW_SURROGATES
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _LOW_SURROGATES6369)) as java.lang.Character.UnicodeBlock;
				}
			}
			static UnicodeBlock()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.lang.Character.UnicodeBlock.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Character$UnicodeBlock"));
				global::java.lang.Character.UnicodeBlock._BASIC_LATIN6244 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "BASIC_LATIN", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._LATIN_1_SUPPLEMENT6245 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "LATIN_1_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._LATIN_EXTENDED_A6246 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "LATIN_EXTENDED_A", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._LATIN_EXTENDED_B6247 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "LATIN_EXTENDED_B", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._IPA_EXTENSIONS6248 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "IPA_EXTENSIONS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._SPACING_MODIFIER_LETTERS6249 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "SPACING_MODIFIER_LETTERS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._COMBINING_DIACRITICAL_MARKS6250 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "COMBINING_DIACRITICAL_MARKS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._GREEK6251 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "GREEK", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CYRILLIC6252 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CYRILLIC", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._ARMENIAN6253 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "ARMENIAN", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._HEBREW6254 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "HEBREW", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._ARABIC6255 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "ARABIC", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._DEVANAGARI6256 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "DEVANAGARI", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._BENGALI6257 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "BENGALI", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._GURMUKHI6258 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "GURMUKHI", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._GUJARATI6259 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "GUJARATI", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._ORIYA6260 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "ORIYA", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._TAMIL6261 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "TAMIL", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._TELUGU6262 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "TELUGU", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._KANNADA6263 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "KANNADA", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._MALAYALAM6264 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "MALAYALAM", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._THAI6265 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "THAI", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._LAO6266 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "LAO", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._TIBETAN6267 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "TIBETAN", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._GEORGIAN6268 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "GEORGIAN", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._HANGUL_JAMO6269 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "HANGUL_JAMO", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._LATIN_EXTENDED_ADDITIONAL6270 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "LATIN_EXTENDED_ADDITIONAL", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._GREEK_EXTENDED6271 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "GREEK_EXTENDED", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._GENERAL_PUNCTUATION6272 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "GENERAL_PUNCTUATION", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._SUPERSCRIPTS_AND_SUBSCRIPTS6273 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "SUPERSCRIPTS_AND_SUBSCRIPTS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CURRENCY_SYMBOLS6274 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CURRENCY_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._COMBINING_MARKS_FOR_SYMBOLS6275 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "COMBINING_MARKS_FOR_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._LETTERLIKE_SYMBOLS6276 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "LETTERLIKE_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._NUMBER_FORMS6277 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "NUMBER_FORMS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._ARROWS6278 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "ARROWS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._MATHEMATICAL_OPERATORS6279 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "MATHEMATICAL_OPERATORS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._MISCELLANEOUS_TECHNICAL6280 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "MISCELLANEOUS_TECHNICAL", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CONTROL_PICTURES6281 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CONTROL_PICTURES", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._OPTICAL_CHARACTER_RECOGNITION6282 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "OPTICAL_CHARACTER_RECOGNITION", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._ENCLOSED_ALPHANUMERICS6283 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "ENCLOSED_ALPHANUMERICS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._BOX_DRAWING6284 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "BOX_DRAWING", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._BLOCK_ELEMENTS6285 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "BLOCK_ELEMENTS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._GEOMETRIC_SHAPES6286 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "GEOMETRIC_SHAPES", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._MISCELLANEOUS_SYMBOLS6287 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "MISCELLANEOUS_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._DINGBATS6288 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "DINGBATS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CJK_SYMBOLS_AND_PUNCTUATION6289 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CJK_SYMBOLS_AND_PUNCTUATION", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._HIRAGANA6290 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "HIRAGANA", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._KATAKANA6291 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "KATAKANA", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._BOPOMOFO6292 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "BOPOMOFO", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._HANGUL_COMPATIBILITY_JAMO6293 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "HANGUL_COMPATIBILITY_JAMO", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._KANBUN6294 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "KANBUN", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._ENCLOSED_CJK_LETTERS_AND_MONTHS6295 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "ENCLOSED_CJK_LETTERS_AND_MONTHS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CJK_COMPATIBILITY6296 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CJK_COMPATIBILITY", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CJK_UNIFIED_IDEOGRAPHS6297 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CJK_UNIFIED_IDEOGRAPHS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._HANGUL_SYLLABLES6298 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "HANGUL_SYLLABLES", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._PRIVATE_USE_AREA6299 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "PRIVATE_USE_AREA", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CJK_COMPATIBILITY_IDEOGRAPHS6300 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CJK_COMPATIBILITY_IDEOGRAPHS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._ALPHABETIC_PRESENTATION_FORMS6301 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "ALPHABETIC_PRESENTATION_FORMS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._ARABIC_PRESENTATION_FORMS_A6302 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "ARABIC_PRESENTATION_FORMS_A", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._COMBINING_HALF_MARKS6303 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "COMBINING_HALF_MARKS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CJK_COMPATIBILITY_FORMS6304 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CJK_COMPATIBILITY_FORMS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._SMALL_FORM_VARIANTS6305 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "SMALL_FORM_VARIANTS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._ARABIC_PRESENTATION_FORMS_B6306 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "ARABIC_PRESENTATION_FORMS_B", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._HALFWIDTH_AND_FULLWIDTH_FORMS6307 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "HALFWIDTH_AND_FULLWIDTH_FORMS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._SPECIALS6308 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "SPECIALS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._SURROGATES_AREA6309 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "SURROGATES_AREA", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._SYRIAC6310 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "SYRIAC", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._THAANA6311 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "THAANA", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._SINHALA6312 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "SINHALA", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._MYANMAR6313 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "MYANMAR", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._ETHIOPIC6314 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "ETHIOPIC", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CHEROKEE6315 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CHEROKEE", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._UNIFIED_CANADIAN_ABORIGINAL_SYLLABICS6316 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "UNIFIED_CANADIAN_ABORIGINAL_SYLLABICS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._OGHAM6317 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "OGHAM", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._RUNIC6318 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "RUNIC", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._KHMER6319 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "KHMER", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._MONGOLIAN6320 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "MONGOLIAN", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._BRAILLE_PATTERNS6321 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "BRAILLE_PATTERNS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CJK_RADICALS_SUPPLEMENT6322 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CJK_RADICALS_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._KANGXI_RADICALS6323 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "KANGXI_RADICALS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._IDEOGRAPHIC_DESCRIPTION_CHARACTERS6324 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "IDEOGRAPHIC_DESCRIPTION_CHARACTERS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._BOPOMOFO_EXTENDED6325 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "BOPOMOFO_EXTENDED", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CJK_UNIFIED_IDEOGRAPHS_EXTENSION_A6326 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CJK_UNIFIED_IDEOGRAPHS_EXTENSION_A", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._YI_SYLLABLES6327 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "YI_SYLLABLES", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._YI_RADICALS6328 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "YI_RADICALS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CYRILLIC_SUPPLEMENTARY6329 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CYRILLIC_SUPPLEMENTARY", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._TAGALOG6330 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "TAGALOG", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._HANUNOO6331 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "HANUNOO", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._BUHID6332 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "BUHID", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._TAGBANWA6333 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "TAGBANWA", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._LIMBU6334 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "LIMBU", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._TAI_LE6335 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "TAI_LE", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._KHMER_SYMBOLS6336 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "KHMER_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._PHONETIC_EXTENSIONS6337 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "PHONETIC_EXTENSIONS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._MISCELLANEOUS_MATHEMATICAL_SYMBOLS_A6338 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "MISCELLANEOUS_MATHEMATICAL_SYMBOLS_A", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._SUPPLEMENTAL_ARROWS_A6339 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "SUPPLEMENTAL_ARROWS_A", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._SUPPLEMENTAL_ARROWS_B6340 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "SUPPLEMENTAL_ARROWS_B", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._MISCELLANEOUS_MATHEMATICAL_SYMBOLS_B6341 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "MISCELLANEOUS_MATHEMATICAL_SYMBOLS_B", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._SUPPLEMENTAL_MATHEMATICAL_OPERATORS6342 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "SUPPLEMENTAL_MATHEMATICAL_OPERATORS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._MISCELLANEOUS_SYMBOLS_AND_ARROWS6343 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "MISCELLANEOUS_SYMBOLS_AND_ARROWS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._KATAKANA_PHONETIC_EXTENSIONS6344 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "KATAKANA_PHONETIC_EXTENSIONS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._YIJING_HEXAGRAM_SYMBOLS6345 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "YIJING_HEXAGRAM_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._VARIATION_SELECTORS6346 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "VARIATION_SELECTORS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._LINEAR_B_SYLLABARY6347 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "LINEAR_B_SYLLABARY", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._LINEAR_B_IDEOGRAMS6348 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "LINEAR_B_IDEOGRAMS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._AEGEAN_NUMBERS6349 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "AEGEAN_NUMBERS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._OLD_ITALIC6350 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "OLD_ITALIC", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._GOTHIC6351 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "GOTHIC", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._UGARITIC6352 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "UGARITIC", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._DESERET6353 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "DESERET", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._SHAVIAN6354 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "SHAVIAN", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._OSMANYA6355 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "OSMANYA", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CYPRIOT_SYLLABARY6356 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CYPRIOT_SYLLABARY", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._BYZANTINE_MUSICAL_SYMBOLS6357 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "BYZANTINE_MUSICAL_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._MUSICAL_SYMBOLS6358 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "MUSICAL_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._TAI_XUAN_JING_SYMBOLS6359 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "TAI_XUAN_JING_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._MATHEMATICAL_ALPHANUMERIC_SYMBOLS6360 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "MATHEMATICAL_ALPHANUMERIC_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CJK_UNIFIED_IDEOGRAPHS_EXTENSION_B6361 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CJK_UNIFIED_IDEOGRAPHS_EXTENSION_B", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CJK_COMPATIBILITY_IDEOGRAPHS_SUPPLEMENT6362 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CJK_COMPATIBILITY_IDEOGRAPHS_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._TAGS6363 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "TAGS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._VARIATION_SELECTORS_SUPPLEMENT6364 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "VARIATION_SELECTORS_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._SUPPLEMENTARY_PRIVATE_USE_AREA_A6365 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "SUPPLEMENTARY_PRIVATE_USE_AREA_A", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._SUPPLEMENTARY_PRIVATE_USE_AREA_B6366 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "SUPPLEMENTARY_PRIVATE_USE_AREA_B", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._HIGH_SURROGATES6367 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "HIGH_SURROGATES", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._HIGH_PRIVATE_USE_SURROGATES6368 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "HIGH_PRIVATE_USE_SURROGATES", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._LOW_SURROGATES6369 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "LOW_SURROGATES", "Ljava/lang/Character$UnicodeBlock;");
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static bool isJavaIdentifierStart(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m0.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m0 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isJavaIdentifierStart", "(C)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static bool isJavaIdentifierStart(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m1.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m1 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isJavaIdentifierStart", "(I)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static bool isJavaIdentifierPart(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m2.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m2 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isJavaIdentifierPart", "(I)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static bool isJavaIdentifierPart(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m3.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m3 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isJavaIdentifierPart", "(C)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Character.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.lang.Character._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.Character.staticClass, "toString", "()Ljava/lang/String;", ref global::java.lang.Character._m5) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::java.lang.String toString(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m6.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m6 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "toString", "(C)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Character.staticClass, global::java.lang.Character._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Character.staticClass, "hashCode", "()I", ref global::java.lang.Character._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static char reverseBytes(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m8.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m8 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "reverseBytes", "(C)C");
			return @__env.CallStaticCharMethod(java.lang.Character.staticClass, global::java.lang.Character._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Character.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::java.lang.Character._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public int compareTo(java.lang.Character arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Character.staticClass, "compareTo", "(Ljava/lang/Character;)I", ref global::java.lang.Character._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static int codePointAt(char[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m11.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m11 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "codePointAt", "([CI)I");
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static int codePointAt(java.lang.CharSequence arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m12.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m12 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "codePointAt", "(Ljava/lang/CharSequence;I)I");
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public static int codePointAt(string arg0, int arg1)
		{
			return codePointAt((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static int codePointAt(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m13.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m13 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "codePointAt", "([CII)I");
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static int codePointBefore(java.lang.CharSequence arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m14.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m14 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "codePointBefore", "(Ljava/lang/CharSequence;I)I");
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public static int codePointBefore(string arg0, int arg1)
		{
			return codePointBefore((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static int codePointBefore(char[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m15.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m15 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "codePointBefore", "([CI)I");
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public static int codePointBefore(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m16.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m16 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "codePointBefore", "([CII)I");
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public static int codePointCount(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m17.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m17 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "codePointCount", "(Ljava/lang/CharSequence;II)I");
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public static int codePointCount(string arg0, int arg1, int arg2)
		{
			return codePointCount((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public static int codePointCount(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m18.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m18 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "codePointCount", "([CII)I");
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public static int offsetByCodePoints(char[] arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m19.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m19 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "offsetByCodePoints", "([CIIII)I");
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public static int offsetByCodePoints(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m20.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m20 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "offsetByCodePoints", "(Ljava/lang/CharSequence;II)I");
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public static int offsetByCodePoints(string arg0, int arg1, int arg2)
		{
			return offsetByCodePoints((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public static int toLowerCase(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m21.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m21 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "toLowerCase", "(I)I");
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public static char toLowerCase(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m22.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m22 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "toLowerCase", "(C)C");
			return @__env.CallStaticCharMethod(java.lang.Character.staticClass, global::java.lang.Character._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public static char toUpperCase(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m23.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m23 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "toUpperCase", "(C)C");
			return @__env.CallStaticCharMethod(java.lang.Character.staticClass, global::java.lang.Character._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public static int toUpperCase(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m24.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m24 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "toUpperCase", "(I)I");
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public static global::java.lang.Character valueOf(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m25.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m25 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "valueOf", "(C)Ljava/lang/Character;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character>(@__env.CallStaticObjectMethod(java.lang.Character.staticClass, global::java.lang.Character._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Character;
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public static char[] toChars(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m26.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m26 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "toChars", "(I)[C");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallStaticObjectMethod(java.lang.Character.staticClass, global::java.lang.Character._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as char[];
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public static int toChars(int arg0, char[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m27.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m27 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "toChars", "(I[CI)I");
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public static int charCount(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m28.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m28 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "charCount", "(I)I");
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public static int getType(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m29.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m29 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "getType", "(I)I");
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public static int getType(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m30.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m30 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "getType", "(C)I");
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public static bool isValidCodePoint(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m31.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m31 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isValidCodePoint", "(I)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public static bool isLowSurrogate(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m32.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m32 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isLowSurrogate", "(C)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public static bool isHighSurrogate(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m33.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m33 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isHighSurrogate", "(C)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public char charValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.lang.Character.staticClass, "charValue", "()C", ref global::java.lang.Character._m34);
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public static bool isSupplementaryCodePoint(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m35.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m35 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isSupplementaryCodePoint", "(I)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public static bool isSurrogatePair(char arg0, char arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m36.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m36 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isSurrogatePair", "(CC)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public static int toCodePoint(char arg0, char arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m37.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m37 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "toCodePoint", "(CC)I");
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public static bool isLowerCase(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m38.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m38 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isLowerCase", "(I)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public static bool isLowerCase(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m39.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m39 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isLowerCase", "(C)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public static bool isUpperCase(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m40.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m40 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isUpperCase", "(I)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public static bool isUpperCase(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m41.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m41 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isUpperCase", "(C)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public static bool isTitleCase(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m42.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m42 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isTitleCase", "(C)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public static bool isTitleCase(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m43.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m43 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isTitleCase", "(I)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public static bool isDigit(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m44.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m44 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isDigit", "(I)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public static bool isDigit(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m45.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m45 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isDigit", "(C)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public static bool isDefined(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m46.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m46 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isDefined", "(I)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public static bool isDefined(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m47.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m47 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isDefined", "(C)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public static bool isLetter(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m48.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m48 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isLetter", "(C)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._m48, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public static bool isLetter(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m49.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m49 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isLetter", "(I)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._m49, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m50;
		public static bool isLetterOrDigit(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m50.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m50 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isLetterOrDigit", "(C)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._m50, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m51;
		public static bool isLetterOrDigit(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m51.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m51 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isLetterOrDigit", "(I)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._m51, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m52;
		public static bool isJavaLetter(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m52.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m52 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isJavaLetter", "(C)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._m52, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m53;
		public static bool isJavaLetterOrDigit(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m53.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m53 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isJavaLetterOrDigit", "(C)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._m53, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m54;
		public static bool isUnicodeIdentifierStart(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m54.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m54 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isUnicodeIdentifierStart", "(C)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._m54, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m55;
		public static bool isUnicodeIdentifierStart(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m55.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m55 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isUnicodeIdentifierStart", "(I)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._m55, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m56;
		public static bool isUnicodeIdentifierPart(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m56.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m56 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isUnicodeIdentifierPart", "(C)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._m56, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m57;
		public static bool isUnicodeIdentifierPart(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m57.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m57 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isUnicodeIdentifierPart", "(I)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._m57, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m58;
		public static bool isIdentifierIgnorable(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m58.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m58 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isIdentifierIgnorable", "(I)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._m58, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m59;
		public static bool isIdentifierIgnorable(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m59.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m59 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isIdentifierIgnorable", "(C)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._m59, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m60;
		public static char toTitleCase(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m60.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m60 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "toTitleCase", "(C)C");
			return @__env.CallStaticCharMethod(java.lang.Character.staticClass, global::java.lang.Character._m60, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m61;
		public static int toTitleCase(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m61.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m61 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "toTitleCase", "(I)I");
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._m61, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m62;
		public static int digit(char arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m62.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m62 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "digit", "(CI)I");
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._m62, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m63;
		public static int digit(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m63.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m63 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "digit", "(II)I");
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._m63, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m64;
		public static int getNumericValue(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m64.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m64 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "getNumericValue", "(C)I");
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._m64, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m65;
		public static int getNumericValue(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m65.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m65 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "getNumericValue", "(I)I");
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._m65, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m66;
		public static bool isSpace(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m66.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m66 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isSpace", "(C)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._m66, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m67;
		public static bool isSpaceChar(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m67.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m67 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isSpaceChar", "(C)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._m67, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m68;
		public static bool isSpaceChar(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m68.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m68 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isSpaceChar", "(I)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._m68, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m69;
		public static bool isWhitespace(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m69.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m69 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isWhitespace", "(I)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._m69, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m70;
		public static bool isWhitespace(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m70.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m70 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isWhitespace", "(C)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._m70, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m71;
		public static bool isISOControl(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m71.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m71 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isISOControl", "(I)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._m71, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m72;
		public static bool isISOControl(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m72.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m72 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isISOControl", "(C)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._m72, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m73;
		public static char forDigit(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m73.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m73 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "forDigit", "(II)C");
			return @__env.CallStaticCharMethod(java.lang.Character.staticClass, global::java.lang.Character._m73, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m74;
		public static byte getDirectionality(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m74.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m74 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "getDirectionality", "(C)B");
			return @__env.CallStaticByteMethod(java.lang.Character.staticClass, global::java.lang.Character._m74, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m75;
		public static byte getDirectionality(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m75.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m75 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "getDirectionality", "(I)B");
			return @__env.CallStaticByteMethod(java.lang.Character.staticClass, global::java.lang.Character._m75, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m76;
		public static bool isMirrored(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m76.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m76 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isMirrored", "(I)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._m76, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m77;
		public static bool isMirrored(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m77.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m77 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isMirrored", "(C)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._m77, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m78;
		public Character(char arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Character._m78.native == global::System.IntPtr.Zero)
				global::java.lang.Character._m78 = @__env.GetMethodIDNoThrow(global::java.lang.Character.staticClass, "<init>", "(C)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Character.staticClass, global::java.lang.Character._m78, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Character()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Character.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Character"));
		}
	}
}
