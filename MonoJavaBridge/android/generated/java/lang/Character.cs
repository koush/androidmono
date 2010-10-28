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
			internal static global::MonoJavaBridge.MethodId _equals19765;
			public sealed override bool equals(java.lang.Object arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Character.Subset._equals19765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Character.Subset.staticClass, global::java.lang.Character.Subset._equals19765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _toString19766;
			public sealed override global::java.lang.String toString()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Character.Subset._toString19766)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Character.Subset.staticClass, global::java.lang.Character.Subset._toString19766)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _hashCode19767;
			public sealed override int hashCode()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Character.Subset._hashCode19767);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Character.Subset.staticClass, global::java.lang.Character.Subset._hashCode19767);
			}
			internal static global::MonoJavaBridge.MethodId _Subset19768;
			protected Subset(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Character.Subset.staticClass, global::java.lang.Character.Subset._Subset19768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static Subset()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.lang.Character.Subset.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Character$Subset"));
				global::java.lang.Character.Subset._equals19765 = @__env.GetMethodIDNoThrow(global::java.lang.Character.Subset.staticClass, "equals", "(Ljava/lang/Object;)Z");
				global::java.lang.Character.Subset._toString19766 = @__env.GetMethodIDNoThrow(global::java.lang.Character.Subset.staticClass, "toString", "()Ljava/lang/String;");
				global::java.lang.Character.Subset._hashCode19767 = @__env.GetMethodIDNoThrow(global::java.lang.Character.Subset.staticClass, "hashCode", "()I");
				global::java.lang.Character.Subset._Subset19768 = @__env.GetMethodIDNoThrow(global::java.lang.Character.Subset.staticClass, "<init>", "(Ljava/lang/String;)V");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class UnicodeBlock : java.lang.Character.Subset
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal UnicodeBlock(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _forName19769;
			public static global::java.lang.Character.UnicodeBlock forName(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.CallStaticObjectMethod(java.lang.Character.UnicodeBlock.staticClass, global::java.lang.Character.UnicodeBlock._forName19769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Character.UnicodeBlock;
			}
			internal static global::MonoJavaBridge.MethodId _of19770;
			public static global::java.lang.Character.UnicodeBlock of(char arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.CallStaticObjectMethod(java.lang.Character.UnicodeBlock.staticClass, global::java.lang.Character.UnicodeBlock._of19770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Character.UnicodeBlock;
			}
			internal static global::MonoJavaBridge.MethodId _of19771;
			public static global::java.lang.Character.UnicodeBlock of(int arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.CallStaticObjectMethod(java.lang.Character.UnicodeBlock.staticClass, global::java.lang.Character.UnicodeBlock._of19771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Character.UnicodeBlock;
			}
			internal static global::MonoJavaBridge.FieldId _BASIC_LATIN19772;
			public static global::java.lang.Character.UnicodeBlock BASIC_LATIN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _BASIC_LATIN19772)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LATIN_1_SUPPLEMENT19773;
			public static global::java.lang.Character.UnicodeBlock LATIN_1_SUPPLEMENT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _LATIN_1_SUPPLEMENT19773)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LATIN_EXTENDED_A19774;
			public static global::java.lang.Character.UnicodeBlock LATIN_EXTENDED_A
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _LATIN_EXTENDED_A19774)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LATIN_EXTENDED_B19775;
			public static global::java.lang.Character.UnicodeBlock LATIN_EXTENDED_B
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _LATIN_EXTENDED_B19775)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _IPA_EXTENSIONS19776;
			public static global::java.lang.Character.UnicodeBlock IPA_EXTENSIONS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _IPA_EXTENSIONS19776)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SPACING_MODIFIER_LETTERS19777;
			public static global::java.lang.Character.UnicodeBlock SPACING_MODIFIER_LETTERS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _SPACING_MODIFIER_LETTERS19777)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _COMBINING_DIACRITICAL_MARKS19778;
			public static global::java.lang.Character.UnicodeBlock COMBINING_DIACRITICAL_MARKS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _COMBINING_DIACRITICAL_MARKS19778)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _GREEK19779;
			public static global::java.lang.Character.UnicodeBlock GREEK
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _GREEK19779)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CYRILLIC19780;
			public static global::java.lang.Character.UnicodeBlock CYRILLIC
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CYRILLIC19780)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ARMENIAN19781;
			public static global::java.lang.Character.UnicodeBlock ARMENIAN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _ARMENIAN19781)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _HEBREW19782;
			public static global::java.lang.Character.UnicodeBlock HEBREW
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _HEBREW19782)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ARABIC19783;
			public static global::java.lang.Character.UnicodeBlock ARABIC
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _ARABIC19783)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DEVANAGARI19784;
			public static global::java.lang.Character.UnicodeBlock DEVANAGARI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _DEVANAGARI19784)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _BENGALI19785;
			public static global::java.lang.Character.UnicodeBlock BENGALI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _BENGALI19785)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _GURMUKHI19786;
			public static global::java.lang.Character.UnicodeBlock GURMUKHI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _GURMUKHI19786)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _GUJARATI19787;
			public static global::java.lang.Character.UnicodeBlock GUJARATI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _GUJARATI19787)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ORIYA19788;
			public static global::java.lang.Character.UnicodeBlock ORIYA
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _ORIYA19788)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TAMIL19789;
			public static global::java.lang.Character.UnicodeBlock TAMIL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _TAMIL19789)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TELUGU19790;
			public static global::java.lang.Character.UnicodeBlock TELUGU
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _TELUGU19790)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _KANNADA19791;
			public static global::java.lang.Character.UnicodeBlock KANNADA
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _KANNADA19791)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MALAYALAM19792;
			public static global::java.lang.Character.UnicodeBlock MALAYALAM
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _MALAYALAM19792)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _THAI19793;
			public static global::java.lang.Character.UnicodeBlock THAI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _THAI19793)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LAO19794;
			public static global::java.lang.Character.UnicodeBlock LAO
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _LAO19794)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TIBETAN19795;
			public static global::java.lang.Character.UnicodeBlock TIBETAN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _TIBETAN19795)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _GEORGIAN19796;
			public static global::java.lang.Character.UnicodeBlock GEORGIAN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _GEORGIAN19796)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _HANGUL_JAMO19797;
			public static global::java.lang.Character.UnicodeBlock HANGUL_JAMO
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _HANGUL_JAMO19797)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LATIN_EXTENDED_ADDITIONAL19798;
			public static global::java.lang.Character.UnicodeBlock LATIN_EXTENDED_ADDITIONAL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _LATIN_EXTENDED_ADDITIONAL19798)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _GREEK_EXTENDED19799;
			public static global::java.lang.Character.UnicodeBlock GREEK_EXTENDED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _GREEK_EXTENDED19799)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _GENERAL_PUNCTUATION19800;
			public static global::java.lang.Character.UnicodeBlock GENERAL_PUNCTUATION
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _GENERAL_PUNCTUATION19800)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SUPERSCRIPTS_AND_SUBSCRIPTS19801;
			public static global::java.lang.Character.UnicodeBlock SUPERSCRIPTS_AND_SUBSCRIPTS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _SUPERSCRIPTS_AND_SUBSCRIPTS19801)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CURRENCY_SYMBOLS19802;
			public static global::java.lang.Character.UnicodeBlock CURRENCY_SYMBOLS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CURRENCY_SYMBOLS19802)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _COMBINING_MARKS_FOR_SYMBOLS19803;
			public static global::java.lang.Character.UnicodeBlock COMBINING_MARKS_FOR_SYMBOLS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _COMBINING_MARKS_FOR_SYMBOLS19803)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LETTERLIKE_SYMBOLS19804;
			public static global::java.lang.Character.UnicodeBlock LETTERLIKE_SYMBOLS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _LETTERLIKE_SYMBOLS19804)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _NUMBER_FORMS19805;
			public static global::java.lang.Character.UnicodeBlock NUMBER_FORMS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _NUMBER_FORMS19805)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ARROWS19806;
			public static global::java.lang.Character.UnicodeBlock ARROWS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _ARROWS19806)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MATHEMATICAL_OPERATORS19807;
			public static global::java.lang.Character.UnicodeBlock MATHEMATICAL_OPERATORS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _MATHEMATICAL_OPERATORS19807)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MISCELLANEOUS_TECHNICAL19808;
			public static global::java.lang.Character.UnicodeBlock MISCELLANEOUS_TECHNICAL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _MISCELLANEOUS_TECHNICAL19808)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CONTROL_PICTURES19809;
			public static global::java.lang.Character.UnicodeBlock CONTROL_PICTURES
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CONTROL_PICTURES19809)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _OPTICAL_CHARACTER_RECOGNITION19810;
			public static global::java.lang.Character.UnicodeBlock OPTICAL_CHARACTER_RECOGNITION
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _OPTICAL_CHARACTER_RECOGNITION19810)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ENCLOSED_ALPHANUMERICS19811;
			public static global::java.lang.Character.UnicodeBlock ENCLOSED_ALPHANUMERICS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _ENCLOSED_ALPHANUMERICS19811)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _BOX_DRAWING19812;
			public static global::java.lang.Character.UnicodeBlock BOX_DRAWING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _BOX_DRAWING19812)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _BLOCK_ELEMENTS19813;
			public static global::java.lang.Character.UnicodeBlock BLOCK_ELEMENTS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _BLOCK_ELEMENTS19813)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _GEOMETRIC_SHAPES19814;
			public static global::java.lang.Character.UnicodeBlock GEOMETRIC_SHAPES
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _GEOMETRIC_SHAPES19814)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MISCELLANEOUS_SYMBOLS19815;
			public static global::java.lang.Character.UnicodeBlock MISCELLANEOUS_SYMBOLS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _MISCELLANEOUS_SYMBOLS19815)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DINGBATS19816;
			public static global::java.lang.Character.UnicodeBlock DINGBATS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _DINGBATS19816)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CJK_SYMBOLS_AND_PUNCTUATION19817;
			public static global::java.lang.Character.UnicodeBlock CJK_SYMBOLS_AND_PUNCTUATION
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CJK_SYMBOLS_AND_PUNCTUATION19817)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _HIRAGANA19818;
			public static global::java.lang.Character.UnicodeBlock HIRAGANA
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _HIRAGANA19818)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _KATAKANA19819;
			public static global::java.lang.Character.UnicodeBlock KATAKANA
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _KATAKANA19819)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _BOPOMOFO19820;
			public static global::java.lang.Character.UnicodeBlock BOPOMOFO
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _BOPOMOFO19820)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _HANGUL_COMPATIBILITY_JAMO19821;
			public static global::java.lang.Character.UnicodeBlock HANGUL_COMPATIBILITY_JAMO
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _HANGUL_COMPATIBILITY_JAMO19821)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _KANBUN19822;
			public static global::java.lang.Character.UnicodeBlock KANBUN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _KANBUN19822)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ENCLOSED_CJK_LETTERS_AND_MONTHS19823;
			public static global::java.lang.Character.UnicodeBlock ENCLOSED_CJK_LETTERS_AND_MONTHS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _ENCLOSED_CJK_LETTERS_AND_MONTHS19823)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CJK_COMPATIBILITY19824;
			public static global::java.lang.Character.UnicodeBlock CJK_COMPATIBILITY
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CJK_COMPATIBILITY19824)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CJK_UNIFIED_IDEOGRAPHS19825;
			public static global::java.lang.Character.UnicodeBlock CJK_UNIFIED_IDEOGRAPHS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CJK_UNIFIED_IDEOGRAPHS19825)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _HANGUL_SYLLABLES19826;
			public static global::java.lang.Character.UnicodeBlock HANGUL_SYLLABLES
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _HANGUL_SYLLABLES19826)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _PRIVATE_USE_AREA19827;
			public static global::java.lang.Character.UnicodeBlock PRIVATE_USE_AREA
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _PRIVATE_USE_AREA19827)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CJK_COMPATIBILITY_IDEOGRAPHS19828;
			public static global::java.lang.Character.UnicodeBlock CJK_COMPATIBILITY_IDEOGRAPHS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CJK_COMPATIBILITY_IDEOGRAPHS19828)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ALPHABETIC_PRESENTATION_FORMS19829;
			public static global::java.lang.Character.UnicodeBlock ALPHABETIC_PRESENTATION_FORMS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _ALPHABETIC_PRESENTATION_FORMS19829)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ARABIC_PRESENTATION_FORMS_A19830;
			public static global::java.lang.Character.UnicodeBlock ARABIC_PRESENTATION_FORMS_A
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _ARABIC_PRESENTATION_FORMS_A19830)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _COMBINING_HALF_MARKS19831;
			public static global::java.lang.Character.UnicodeBlock COMBINING_HALF_MARKS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _COMBINING_HALF_MARKS19831)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CJK_COMPATIBILITY_FORMS19832;
			public static global::java.lang.Character.UnicodeBlock CJK_COMPATIBILITY_FORMS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CJK_COMPATIBILITY_FORMS19832)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SMALL_FORM_VARIANTS19833;
			public static global::java.lang.Character.UnicodeBlock SMALL_FORM_VARIANTS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _SMALL_FORM_VARIANTS19833)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ARABIC_PRESENTATION_FORMS_B19834;
			public static global::java.lang.Character.UnicodeBlock ARABIC_PRESENTATION_FORMS_B
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _ARABIC_PRESENTATION_FORMS_B19834)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _HALFWIDTH_AND_FULLWIDTH_FORMS19835;
			public static global::java.lang.Character.UnicodeBlock HALFWIDTH_AND_FULLWIDTH_FORMS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _HALFWIDTH_AND_FULLWIDTH_FORMS19835)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SPECIALS19836;
			public static global::java.lang.Character.UnicodeBlock SPECIALS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _SPECIALS19836)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SURROGATES_AREA19837;
			public static global::java.lang.Character.UnicodeBlock SURROGATES_AREA
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _SURROGATES_AREA19837)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SYRIAC19838;
			public static global::java.lang.Character.UnicodeBlock SYRIAC
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _SYRIAC19838)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _THAANA19839;
			public static global::java.lang.Character.UnicodeBlock THAANA
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _THAANA19839)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SINHALA19840;
			public static global::java.lang.Character.UnicodeBlock SINHALA
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _SINHALA19840)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MYANMAR19841;
			public static global::java.lang.Character.UnicodeBlock MYANMAR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _MYANMAR19841)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ETHIOPIC19842;
			public static global::java.lang.Character.UnicodeBlock ETHIOPIC
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _ETHIOPIC19842)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CHEROKEE19843;
			public static global::java.lang.Character.UnicodeBlock CHEROKEE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CHEROKEE19843)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _UNIFIED_CANADIAN_ABORIGINAL_SYLLABICS19844;
			public static global::java.lang.Character.UnicodeBlock UNIFIED_CANADIAN_ABORIGINAL_SYLLABICS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _UNIFIED_CANADIAN_ABORIGINAL_SYLLABICS19844)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _OGHAM19845;
			public static global::java.lang.Character.UnicodeBlock OGHAM
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _OGHAM19845)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _RUNIC19846;
			public static global::java.lang.Character.UnicodeBlock RUNIC
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _RUNIC19846)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _KHMER19847;
			public static global::java.lang.Character.UnicodeBlock KHMER
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _KHMER19847)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MONGOLIAN19848;
			public static global::java.lang.Character.UnicodeBlock MONGOLIAN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _MONGOLIAN19848)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _BRAILLE_PATTERNS19849;
			public static global::java.lang.Character.UnicodeBlock BRAILLE_PATTERNS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _BRAILLE_PATTERNS19849)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CJK_RADICALS_SUPPLEMENT19850;
			public static global::java.lang.Character.UnicodeBlock CJK_RADICALS_SUPPLEMENT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CJK_RADICALS_SUPPLEMENT19850)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _KANGXI_RADICALS19851;
			public static global::java.lang.Character.UnicodeBlock KANGXI_RADICALS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _KANGXI_RADICALS19851)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _IDEOGRAPHIC_DESCRIPTION_CHARACTERS19852;
			public static global::java.lang.Character.UnicodeBlock IDEOGRAPHIC_DESCRIPTION_CHARACTERS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _IDEOGRAPHIC_DESCRIPTION_CHARACTERS19852)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _BOPOMOFO_EXTENDED19853;
			public static global::java.lang.Character.UnicodeBlock BOPOMOFO_EXTENDED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _BOPOMOFO_EXTENDED19853)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CJK_UNIFIED_IDEOGRAPHS_EXTENSION_A19854;
			public static global::java.lang.Character.UnicodeBlock CJK_UNIFIED_IDEOGRAPHS_EXTENSION_A
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CJK_UNIFIED_IDEOGRAPHS_EXTENSION_A19854)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _YI_SYLLABLES19855;
			public static global::java.lang.Character.UnicodeBlock YI_SYLLABLES
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _YI_SYLLABLES19855)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _YI_RADICALS19856;
			public static global::java.lang.Character.UnicodeBlock YI_RADICALS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _YI_RADICALS19856)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CYRILLIC_SUPPLEMENTARY19857;
			public static global::java.lang.Character.UnicodeBlock CYRILLIC_SUPPLEMENTARY
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CYRILLIC_SUPPLEMENTARY19857)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TAGALOG19858;
			public static global::java.lang.Character.UnicodeBlock TAGALOG
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _TAGALOG19858)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _HANUNOO19859;
			public static global::java.lang.Character.UnicodeBlock HANUNOO
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _HANUNOO19859)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _BUHID19860;
			public static global::java.lang.Character.UnicodeBlock BUHID
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _BUHID19860)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TAGBANWA19861;
			public static global::java.lang.Character.UnicodeBlock TAGBANWA
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _TAGBANWA19861)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LIMBU19862;
			public static global::java.lang.Character.UnicodeBlock LIMBU
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _LIMBU19862)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TAI_LE19863;
			public static global::java.lang.Character.UnicodeBlock TAI_LE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _TAI_LE19863)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _KHMER_SYMBOLS19864;
			public static global::java.lang.Character.UnicodeBlock KHMER_SYMBOLS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _KHMER_SYMBOLS19864)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _PHONETIC_EXTENSIONS19865;
			public static global::java.lang.Character.UnicodeBlock PHONETIC_EXTENSIONS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _PHONETIC_EXTENSIONS19865)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MISCELLANEOUS_MATHEMATICAL_SYMBOLS_A19866;
			public static global::java.lang.Character.UnicodeBlock MISCELLANEOUS_MATHEMATICAL_SYMBOLS_A
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _MISCELLANEOUS_MATHEMATICAL_SYMBOLS_A19866)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SUPPLEMENTAL_ARROWS_A19867;
			public static global::java.lang.Character.UnicodeBlock SUPPLEMENTAL_ARROWS_A
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _SUPPLEMENTAL_ARROWS_A19867)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SUPPLEMENTAL_ARROWS_B19868;
			public static global::java.lang.Character.UnicodeBlock SUPPLEMENTAL_ARROWS_B
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _SUPPLEMENTAL_ARROWS_B19868)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MISCELLANEOUS_MATHEMATICAL_SYMBOLS_B19869;
			public static global::java.lang.Character.UnicodeBlock MISCELLANEOUS_MATHEMATICAL_SYMBOLS_B
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _MISCELLANEOUS_MATHEMATICAL_SYMBOLS_B19869)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SUPPLEMENTAL_MATHEMATICAL_OPERATORS19870;
			public static global::java.lang.Character.UnicodeBlock SUPPLEMENTAL_MATHEMATICAL_OPERATORS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _SUPPLEMENTAL_MATHEMATICAL_OPERATORS19870)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MISCELLANEOUS_SYMBOLS_AND_ARROWS19871;
			public static global::java.lang.Character.UnicodeBlock MISCELLANEOUS_SYMBOLS_AND_ARROWS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _MISCELLANEOUS_SYMBOLS_AND_ARROWS19871)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _KATAKANA_PHONETIC_EXTENSIONS19872;
			public static global::java.lang.Character.UnicodeBlock KATAKANA_PHONETIC_EXTENSIONS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _KATAKANA_PHONETIC_EXTENSIONS19872)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _YIJING_HEXAGRAM_SYMBOLS19873;
			public static global::java.lang.Character.UnicodeBlock YIJING_HEXAGRAM_SYMBOLS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _YIJING_HEXAGRAM_SYMBOLS19873)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _VARIATION_SELECTORS19874;
			public static global::java.lang.Character.UnicodeBlock VARIATION_SELECTORS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _VARIATION_SELECTORS19874)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LINEAR_B_SYLLABARY19875;
			public static global::java.lang.Character.UnicodeBlock LINEAR_B_SYLLABARY
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _LINEAR_B_SYLLABARY19875)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LINEAR_B_IDEOGRAMS19876;
			public static global::java.lang.Character.UnicodeBlock LINEAR_B_IDEOGRAMS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _LINEAR_B_IDEOGRAMS19876)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _AEGEAN_NUMBERS19877;
			public static global::java.lang.Character.UnicodeBlock AEGEAN_NUMBERS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _AEGEAN_NUMBERS19877)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _OLD_ITALIC19878;
			public static global::java.lang.Character.UnicodeBlock OLD_ITALIC
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _OLD_ITALIC19878)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _GOTHIC19879;
			public static global::java.lang.Character.UnicodeBlock GOTHIC
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _GOTHIC19879)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _UGARITIC19880;
			public static global::java.lang.Character.UnicodeBlock UGARITIC
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _UGARITIC19880)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DESERET19881;
			public static global::java.lang.Character.UnicodeBlock DESERET
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _DESERET19881)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SHAVIAN19882;
			public static global::java.lang.Character.UnicodeBlock SHAVIAN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _SHAVIAN19882)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _OSMANYA19883;
			public static global::java.lang.Character.UnicodeBlock OSMANYA
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _OSMANYA19883)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CYPRIOT_SYLLABARY19884;
			public static global::java.lang.Character.UnicodeBlock CYPRIOT_SYLLABARY
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CYPRIOT_SYLLABARY19884)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _BYZANTINE_MUSICAL_SYMBOLS19885;
			public static global::java.lang.Character.UnicodeBlock BYZANTINE_MUSICAL_SYMBOLS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _BYZANTINE_MUSICAL_SYMBOLS19885)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MUSICAL_SYMBOLS19886;
			public static global::java.lang.Character.UnicodeBlock MUSICAL_SYMBOLS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _MUSICAL_SYMBOLS19886)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TAI_XUAN_JING_SYMBOLS19887;
			public static global::java.lang.Character.UnicodeBlock TAI_XUAN_JING_SYMBOLS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _TAI_XUAN_JING_SYMBOLS19887)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MATHEMATICAL_ALPHANUMERIC_SYMBOLS19888;
			public static global::java.lang.Character.UnicodeBlock MATHEMATICAL_ALPHANUMERIC_SYMBOLS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _MATHEMATICAL_ALPHANUMERIC_SYMBOLS19888)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CJK_UNIFIED_IDEOGRAPHS_EXTENSION_B19889;
			public static global::java.lang.Character.UnicodeBlock CJK_UNIFIED_IDEOGRAPHS_EXTENSION_B
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CJK_UNIFIED_IDEOGRAPHS_EXTENSION_B19889)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CJK_COMPATIBILITY_IDEOGRAPHS_SUPPLEMENT19890;
			public static global::java.lang.Character.UnicodeBlock CJK_COMPATIBILITY_IDEOGRAPHS_SUPPLEMENT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CJK_COMPATIBILITY_IDEOGRAPHS_SUPPLEMENT19890)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TAGS19891;
			public static global::java.lang.Character.UnicodeBlock TAGS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _TAGS19891)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _VARIATION_SELECTORS_SUPPLEMENT19892;
			public static global::java.lang.Character.UnicodeBlock VARIATION_SELECTORS_SUPPLEMENT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _VARIATION_SELECTORS_SUPPLEMENT19892)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SUPPLEMENTARY_PRIVATE_USE_AREA_A19893;
			public static global::java.lang.Character.UnicodeBlock SUPPLEMENTARY_PRIVATE_USE_AREA_A
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _SUPPLEMENTARY_PRIVATE_USE_AREA_A19893)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SUPPLEMENTARY_PRIVATE_USE_AREA_B19894;
			public static global::java.lang.Character.UnicodeBlock SUPPLEMENTARY_PRIVATE_USE_AREA_B
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _SUPPLEMENTARY_PRIVATE_USE_AREA_B19894)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _HIGH_SURROGATES19895;
			public static global::java.lang.Character.UnicodeBlock HIGH_SURROGATES
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _HIGH_SURROGATES19895)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _HIGH_PRIVATE_USE_SURROGATES19896;
			public static global::java.lang.Character.UnicodeBlock HIGH_PRIVATE_USE_SURROGATES
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _HIGH_PRIVATE_USE_SURROGATES19896)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LOW_SURROGATES19897;
			public static global::java.lang.Character.UnicodeBlock LOW_SURROGATES
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _LOW_SURROGATES19897)) as java.lang.Character.UnicodeBlock;
				}
			}
			static UnicodeBlock()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.lang.Character.UnicodeBlock.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Character$UnicodeBlock"));
				global::java.lang.Character.UnicodeBlock._forName19769 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "forName", "(Ljava/lang/String;)Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._of19770 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "of", "(C)Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._of19771 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "of", "(I)Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._BASIC_LATIN19772 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "BASIC_LATIN", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._LATIN_1_SUPPLEMENT19773 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "LATIN_1_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._LATIN_EXTENDED_A19774 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "LATIN_EXTENDED_A", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._LATIN_EXTENDED_B19775 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "LATIN_EXTENDED_B", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._IPA_EXTENSIONS19776 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "IPA_EXTENSIONS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._SPACING_MODIFIER_LETTERS19777 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "SPACING_MODIFIER_LETTERS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._COMBINING_DIACRITICAL_MARKS19778 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "COMBINING_DIACRITICAL_MARKS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._GREEK19779 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "GREEK", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CYRILLIC19780 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CYRILLIC", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._ARMENIAN19781 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "ARMENIAN", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._HEBREW19782 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "HEBREW", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._ARABIC19783 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "ARABIC", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._DEVANAGARI19784 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "DEVANAGARI", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._BENGALI19785 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "BENGALI", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._GURMUKHI19786 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "GURMUKHI", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._GUJARATI19787 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "GUJARATI", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._ORIYA19788 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "ORIYA", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._TAMIL19789 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "TAMIL", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._TELUGU19790 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "TELUGU", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._KANNADA19791 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "KANNADA", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._MALAYALAM19792 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "MALAYALAM", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._THAI19793 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "THAI", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._LAO19794 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "LAO", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._TIBETAN19795 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "TIBETAN", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._GEORGIAN19796 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "GEORGIAN", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._HANGUL_JAMO19797 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "HANGUL_JAMO", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._LATIN_EXTENDED_ADDITIONAL19798 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "LATIN_EXTENDED_ADDITIONAL", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._GREEK_EXTENDED19799 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "GREEK_EXTENDED", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._GENERAL_PUNCTUATION19800 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "GENERAL_PUNCTUATION", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._SUPERSCRIPTS_AND_SUBSCRIPTS19801 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "SUPERSCRIPTS_AND_SUBSCRIPTS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CURRENCY_SYMBOLS19802 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CURRENCY_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._COMBINING_MARKS_FOR_SYMBOLS19803 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "COMBINING_MARKS_FOR_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._LETTERLIKE_SYMBOLS19804 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "LETTERLIKE_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._NUMBER_FORMS19805 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "NUMBER_FORMS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._ARROWS19806 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "ARROWS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._MATHEMATICAL_OPERATORS19807 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "MATHEMATICAL_OPERATORS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._MISCELLANEOUS_TECHNICAL19808 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "MISCELLANEOUS_TECHNICAL", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CONTROL_PICTURES19809 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CONTROL_PICTURES", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._OPTICAL_CHARACTER_RECOGNITION19810 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "OPTICAL_CHARACTER_RECOGNITION", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._ENCLOSED_ALPHANUMERICS19811 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "ENCLOSED_ALPHANUMERICS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._BOX_DRAWING19812 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "BOX_DRAWING", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._BLOCK_ELEMENTS19813 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "BLOCK_ELEMENTS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._GEOMETRIC_SHAPES19814 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "GEOMETRIC_SHAPES", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._MISCELLANEOUS_SYMBOLS19815 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "MISCELLANEOUS_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._DINGBATS19816 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "DINGBATS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CJK_SYMBOLS_AND_PUNCTUATION19817 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CJK_SYMBOLS_AND_PUNCTUATION", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._HIRAGANA19818 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "HIRAGANA", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._KATAKANA19819 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "KATAKANA", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._BOPOMOFO19820 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "BOPOMOFO", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._HANGUL_COMPATIBILITY_JAMO19821 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "HANGUL_COMPATIBILITY_JAMO", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._KANBUN19822 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "KANBUN", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._ENCLOSED_CJK_LETTERS_AND_MONTHS19823 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "ENCLOSED_CJK_LETTERS_AND_MONTHS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CJK_COMPATIBILITY19824 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CJK_COMPATIBILITY", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CJK_UNIFIED_IDEOGRAPHS19825 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CJK_UNIFIED_IDEOGRAPHS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._HANGUL_SYLLABLES19826 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "HANGUL_SYLLABLES", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._PRIVATE_USE_AREA19827 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "PRIVATE_USE_AREA", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CJK_COMPATIBILITY_IDEOGRAPHS19828 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CJK_COMPATIBILITY_IDEOGRAPHS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._ALPHABETIC_PRESENTATION_FORMS19829 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "ALPHABETIC_PRESENTATION_FORMS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._ARABIC_PRESENTATION_FORMS_A19830 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "ARABIC_PRESENTATION_FORMS_A", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._COMBINING_HALF_MARKS19831 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "COMBINING_HALF_MARKS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CJK_COMPATIBILITY_FORMS19832 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CJK_COMPATIBILITY_FORMS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._SMALL_FORM_VARIANTS19833 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "SMALL_FORM_VARIANTS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._ARABIC_PRESENTATION_FORMS_B19834 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "ARABIC_PRESENTATION_FORMS_B", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._HALFWIDTH_AND_FULLWIDTH_FORMS19835 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "HALFWIDTH_AND_FULLWIDTH_FORMS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._SPECIALS19836 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "SPECIALS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._SURROGATES_AREA19837 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "SURROGATES_AREA", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._SYRIAC19838 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "SYRIAC", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._THAANA19839 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "THAANA", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._SINHALA19840 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "SINHALA", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._MYANMAR19841 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "MYANMAR", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._ETHIOPIC19842 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "ETHIOPIC", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CHEROKEE19843 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CHEROKEE", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._UNIFIED_CANADIAN_ABORIGINAL_SYLLABICS19844 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "UNIFIED_CANADIAN_ABORIGINAL_SYLLABICS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._OGHAM19845 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "OGHAM", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._RUNIC19846 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "RUNIC", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._KHMER19847 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "KHMER", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._MONGOLIAN19848 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "MONGOLIAN", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._BRAILLE_PATTERNS19849 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "BRAILLE_PATTERNS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CJK_RADICALS_SUPPLEMENT19850 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CJK_RADICALS_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._KANGXI_RADICALS19851 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "KANGXI_RADICALS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._IDEOGRAPHIC_DESCRIPTION_CHARACTERS19852 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "IDEOGRAPHIC_DESCRIPTION_CHARACTERS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._BOPOMOFO_EXTENDED19853 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "BOPOMOFO_EXTENDED", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CJK_UNIFIED_IDEOGRAPHS_EXTENSION_A19854 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CJK_UNIFIED_IDEOGRAPHS_EXTENSION_A", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._YI_SYLLABLES19855 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "YI_SYLLABLES", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._YI_RADICALS19856 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "YI_RADICALS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CYRILLIC_SUPPLEMENTARY19857 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CYRILLIC_SUPPLEMENTARY", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._TAGALOG19858 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "TAGALOG", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._HANUNOO19859 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "HANUNOO", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._BUHID19860 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "BUHID", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._TAGBANWA19861 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "TAGBANWA", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._LIMBU19862 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "LIMBU", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._TAI_LE19863 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "TAI_LE", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._KHMER_SYMBOLS19864 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "KHMER_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._PHONETIC_EXTENSIONS19865 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "PHONETIC_EXTENSIONS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._MISCELLANEOUS_MATHEMATICAL_SYMBOLS_A19866 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "MISCELLANEOUS_MATHEMATICAL_SYMBOLS_A", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._SUPPLEMENTAL_ARROWS_A19867 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "SUPPLEMENTAL_ARROWS_A", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._SUPPLEMENTAL_ARROWS_B19868 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "SUPPLEMENTAL_ARROWS_B", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._MISCELLANEOUS_MATHEMATICAL_SYMBOLS_B19869 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "MISCELLANEOUS_MATHEMATICAL_SYMBOLS_B", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._SUPPLEMENTAL_MATHEMATICAL_OPERATORS19870 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "SUPPLEMENTAL_MATHEMATICAL_OPERATORS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._MISCELLANEOUS_SYMBOLS_AND_ARROWS19871 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "MISCELLANEOUS_SYMBOLS_AND_ARROWS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._KATAKANA_PHONETIC_EXTENSIONS19872 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "KATAKANA_PHONETIC_EXTENSIONS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._YIJING_HEXAGRAM_SYMBOLS19873 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "YIJING_HEXAGRAM_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._VARIATION_SELECTORS19874 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "VARIATION_SELECTORS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._LINEAR_B_SYLLABARY19875 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "LINEAR_B_SYLLABARY", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._LINEAR_B_IDEOGRAMS19876 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "LINEAR_B_IDEOGRAMS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._AEGEAN_NUMBERS19877 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "AEGEAN_NUMBERS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._OLD_ITALIC19878 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "OLD_ITALIC", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._GOTHIC19879 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "GOTHIC", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._UGARITIC19880 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "UGARITIC", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._DESERET19881 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "DESERET", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._SHAVIAN19882 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "SHAVIAN", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._OSMANYA19883 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "OSMANYA", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CYPRIOT_SYLLABARY19884 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CYPRIOT_SYLLABARY", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._BYZANTINE_MUSICAL_SYMBOLS19885 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "BYZANTINE_MUSICAL_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._MUSICAL_SYMBOLS19886 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "MUSICAL_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._TAI_XUAN_JING_SYMBOLS19887 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "TAI_XUAN_JING_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._MATHEMATICAL_ALPHANUMERIC_SYMBOLS19888 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "MATHEMATICAL_ALPHANUMERIC_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CJK_UNIFIED_IDEOGRAPHS_EXTENSION_B19889 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CJK_UNIFIED_IDEOGRAPHS_EXTENSION_B", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CJK_COMPATIBILITY_IDEOGRAPHS_SUPPLEMENT19890 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CJK_COMPATIBILITY_IDEOGRAPHS_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._TAGS19891 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "TAGS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._VARIATION_SELECTORS_SUPPLEMENT19892 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "VARIATION_SELECTORS_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._SUPPLEMENTARY_PRIVATE_USE_AREA_A19893 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "SUPPLEMENTARY_PRIVATE_USE_AREA_A", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._SUPPLEMENTARY_PRIVATE_USE_AREA_B19894 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "SUPPLEMENTARY_PRIVATE_USE_AREA_B", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._HIGH_SURROGATES19895 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "HIGH_SURROGATES", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._HIGH_PRIVATE_USE_SURROGATES19896 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "HIGH_PRIVATE_USE_SURROGATES", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._LOW_SURROGATES19897 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "LOW_SURROGATES", "Ljava/lang/Character$UnicodeBlock;");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _isJavaIdentifierStart19898;
		public static bool isJavaIdentifierStart(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isJavaIdentifierStart19898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isJavaIdentifierStart19899;
		public static bool isJavaIdentifierStart(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isJavaIdentifierStart19899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isJavaIdentifierPart19900;
		public static bool isJavaIdentifierPart(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isJavaIdentifierPart19900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isJavaIdentifierPart19901;
		public static bool isJavaIdentifierPart(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isJavaIdentifierPart19901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals19902;
		public sealed override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Character._equals19902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Character.staticClass, global::java.lang.Character._equals19902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString19903;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Character._toString19903)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Character.staticClass, global::java.lang.Character._toString19903)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString19904;
		public static global::java.lang.String toString(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Character.staticClass, global::java.lang.Character._toString19904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode19905;
		public sealed override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Character._hashCode19905);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Character.staticClass, global::java.lang.Character._hashCode19905);
		}
		internal static global::MonoJavaBridge.MethodId _reverseBytes19906;
		public static char reverseBytes(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticCharMethod(java.lang.Character.staticClass, global::java.lang.Character._reverseBytes19906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo19907;
		public int compareTo(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Character._compareTo19907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Character.staticClass, global::java.lang.Character._compareTo19907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo19908;
		public int compareTo(java.lang.Character arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Character._compareTo19908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Character.staticClass, global::java.lang.Character._compareTo19908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _codePointAt19909;
		public static int codePointAt(char[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._codePointAt19909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _codePointAt19910;
		public static int codePointAt(java.lang.CharSequence arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._codePointAt19910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public static int codePointAt(string arg0, int arg1)
		{
			return codePointAt((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _codePointAt19911;
		public static int codePointAt(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._codePointAt19911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _codePointBefore19912;
		public static int codePointBefore(java.lang.CharSequence arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._codePointBefore19912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public static int codePointBefore(string arg0, int arg1)
		{
			return codePointBefore((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _codePointBefore19913;
		public static int codePointBefore(char[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._codePointBefore19913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _codePointBefore19914;
		public static int codePointBefore(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._codePointBefore19914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _codePointCount19915;
		public static int codePointCount(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._codePointCount19915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public static int codePointCount(string arg0, int arg1, int arg2)
		{
			return codePointCount((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _codePointCount19916;
		public static int codePointCount(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._codePointCount19916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _offsetByCodePoints19917;
		public static int offsetByCodePoints(char[] arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._offsetByCodePoints19917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _offsetByCodePoints19918;
		public static int offsetByCodePoints(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._offsetByCodePoints19918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public static int offsetByCodePoints(string arg0, int arg1, int arg2)
		{
			return offsetByCodePoints((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _toLowerCase19919;
		public static int toLowerCase(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._toLowerCase19919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toLowerCase19920;
		public static char toLowerCase(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticCharMethod(java.lang.Character.staticClass, global::java.lang.Character._toLowerCase19920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toUpperCase19921;
		public static char toUpperCase(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticCharMethod(java.lang.Character.staticClass, global::java.lang.Character._toUpperCase19921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toUpperCase19922;
		public static int toUpperCase(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._toUpperCase19922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _valueOf19923;
		public static global::java.lang.Character valueOf(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character>(@__env.CallStaticObjectMethod(java.lang.Character.staticClass, global::java.lang.Character._valueOf19923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Character;
		}
		internal static global::MonoJavaBridge.MethodId _toChars19924;
		public static char[] toChars(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallStaticObjectMethod(java.lang.Character.staticClass, global::java.lang.Character._toChars19924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _toChars19925;
		public static int toChars(int arg0, char[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._toChars19925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _charCount19926;
		public static int charCount(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._charCount19926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getType19927;
		public static int getType(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._getType19927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getType19928;
		public static int getType(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._getType19928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isValidCodePoint19929;
		public static bool isValidCodePoint(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isValidCodePoint19929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLowSurrogate19930;
		public static bool isLowSurrogate(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isLowSurrogate19930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isHighSurrogate19931;
		public static bool isHighSurrogate(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isHighSurrogate19931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _charValue19932;
		public char charValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.lang.Character._charValue19932);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.lang.Character.staticClass, global::java.lang.Character._charValue19932);
		}
		internal static global::MonoJavaBridge.MethodId _isSupplementaryCodePoint19933;
		public static bool isSupplementaryCodePoint(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isSupplementaryCodePoint19933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSurrogatePair19934;
		public static bool isSurrogatePair(char arg0, char arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isSurrogatePair19934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _toCodePoint19935;
		public static int toCodePoint(char arg0, char arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._toCodePoint19935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isLowerCase19936;
		public static bool isLowerCase(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isLowerCase19936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLowerCase19937;
		public static bool isLowerCase(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isLowerCase19937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isUpperCase19938;
		public static bool isUpperCase(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isUpperCase19938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isUpperCase19939;
		public static bool isUpperCase(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isUpperCase19939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isTitleCase19940;
		public static bool isTitleCase(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isTitleCase19940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isTitleCase19941;
		public static bool isTitleCase(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isTitleCase19941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDigit19942;
		public static bool isDigit(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isDigit19942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDigit19943;
		public static bool isDigit(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isDigit19943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDefined19944;
		public static bool isDefined(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isDefined19944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDefined19945;
		public static bool isDefined(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isDefined19945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLetter19946;
		public static bool isLetter(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isLetter19946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLetter19947;
		public static bool isLetter(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isLetter19947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLetterOrDigit19948;
		public static bool isLetterOrDigit(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isLetterOrDigit19948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLetterOrDigit19949;
		public static bool isLetterOrDigit(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isLetterOrDigit19949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isJavaLetter19950;
		public static bool isJavaLetter(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isJavaLetter19950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isJavaLetterOrDigit19951;
		public static bool isJavaLetterOrDigit(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isJavaLetterOrDigit19951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isUnicodeIdentifierStart19952;
		public static bool isUnicodeIdentifierStart(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isUnicodeIdentifierStart19952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isUnicodeIdentifierStart19953;
		public static bool isUnicodeIdentifierStart(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isUnicodeIdentifierStart19953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isUnicodeIdentifierPart19954;
		public static bool isUnicodeIdentifierPart(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isUnicodeIdentifierPart19954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isUnicodeIdentifierPart19955;
		public static bool isUnicodeIdentifierPart(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isUnicodeIdentifierPart19955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isIdentifierIgnorable19956;
		public static bool isIdentifierIgnorable(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isIdentifierIgnorable19956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isIdentifierIgnorable19957;
		public static bool isIdentifierIgnorable(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isIdentifierIgnorable19957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toTitleCase19958;
		public static char toTitleCase(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticCharMethod(java.lang.Character.staticClass, global::java.lang.Character._toTitleCase19958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toTitleCase19959;
		public static int toTitleCase(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._toTitleCase19959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _digit19960;
		public static int digit(char arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._digit19960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _digit19961;
		public static int digit(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._digit19961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getNumericValue19962;
		public static int getNumericValue(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._getNumericValue19962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNumericValue19963;
		public static int getNumericValue(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._getNumericValue19963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSpace19964;
		public static bool isSpace(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isSpace19964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSpaceChar19965;
		public static bool isSpaceChar(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isSpaceChar19965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSpaceChar19966;
		public static bool isSpaceChar(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isSpaceChar19966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isWhitespace19967;
		public static bool isWhitespace(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isWhitespace19967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isWhitespace19968;
		public static bool isWhitespace(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isWhitespace19968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isISOControl19969;
		public static bool isISOControl(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isISOControl19969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isISOControl19970;
		public static bool isISOControl(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isISOControl19970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _forDigit19971;
		public static char forDigit(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticCharMethod(java.lang.Character.staticClass, global::java.lang.Character._forDigit19971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDirectionality19972;
		public static byte getDirectionality(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticByteMethod(java.lang.Character.staticClass, global::java.lang.Character._getDirectionality19972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDirectionality19973;
		public static byte getDirectionality(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticByteMethod(java.lang.Character.staticClass, global::java.lang.Character._getDirectionality19973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isMirrored19974;
		public static bool isMirrored(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isMirrored19974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isMirrored19975;
		public static bool isMirrored(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isMirrored19975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Character19976;
		public Character(char arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Character.staticClass, global::java.lang.Character._Character19976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Character()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Character.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Character"));
			global::java.lang.Character._isJavaIdentifierStart19898 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isJavaIdentifierStart", "(C)Z");
			global::java.lang.Character._isJavaIdentifierStart19899 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isJavaIdentifierStart", "(I)Z");
			global::java.lang.Character._isJavaIdentifierPart19900 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isJavaIdentifierPart", "(I)Z");
			global::java.lang.Character._isJavaIdentifierPart19901 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isJavaIdentifierPart", "(C)Z");
			global::java.lang.Character._equals19902 = @__env.GetMethodIDNoThrow(global::java.lang.Character.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.Character._toString19903 = @__env.GetMethodIDNoThrow(global::java.lang.Character.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Character._toString19904 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "toString", "(C)Ljava/lang/String;");
			global::java.lang.Character._hashCode19905 = @__env.GetMethodIDNoThrow(global::java.lang.Character.staticClass, "hashCode", "()I");
			global::java.lang.Character._reverseBytes19906 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "reverseBytes", "(C)C");
			global::java.lang.Character._compareTo19907 = @__env.GetMethodIDNoThrow(global::java.lang.Character.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.lang.Character._compareTo19908 = @__env.GetMethodIDNoThrow(global::java.lang.Character.staticClass, "compareTo", "(Ljava/lang/Character;)I");
			global::java.lang.Character._codePointAt19909 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "codePointAt", "([CI)I");
			global::java.lang.Character._codePointAt19910 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "codePointAt", "(Ljava/lang/CharSequence;I)I");
			global::java.lang.Character._codePointAt19911 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "codePointAt", "([CII)I");
			global::java.lang.Character._codePointBefore19912 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "codePointBefore", "(Ljava/lang/CharSequence;I)I");
			global::java.lang.Character._codePointBefore19913 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "codePointBefore", "([CI)I");
			global::java.lang.Character._codePointBefore19914 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "codePointBefore", "([CII)I");
			global::java.lang.Character._codePointCount19915 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "codePointCount", "(Ljava/lang/CharSequence;II)I");
			global::java.lang.Character._codePointCount19916 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "codePointCount", "([CII)I");
			global::java.lang.Character._offsetByCodePoints19917 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "offsetByCodePoints", "([CIIII)I");
			global::java.lang.Character._offsetByCodePoints19918 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "offsetByCodePoints", "(Ljava/lang/CharSequence;II)I");
			global::java.lang.Character._toLowerCase19919 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "toLowerCase", "(I)I");
			global::java.lang.Character._toLowerCase19920 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "toLowerCase", "(C)C");
			global::java.lang.Character._toUpperCase19921 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "toUpperCase", "(C)C");
			global::java.lang.Character._toUpperCase19922 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "toUpperCase", "(I)I");
			global::java.lang.Character._valueOf19923 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "valueOf", "(C)Ljava/lang/Character;");
			global::java.lang.Character._toChars19924 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "toChars", "(I)[C");
			global::java.lang.Character._toChars19925 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "toChars", "(I[CI)I");
			global::java.lang.Character._charCount19926 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "charCount", "(I)I");
			global::java.lang.Character._getType19927 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "getType", "(I)I");
			global::java.lang.Character._getType19928 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "getType", "(C)I");
			global::java.lang.Character._isValidCodePoint19929 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isValidCodePoint", "(I)Z");
			global::java.lang.Character._isLowSurrogate19930 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isLowSurrogate", "(C)Z");
			global::java.lang.Character._isHighSurrogate19931 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isHighSurrogate", "(C)Z");
			global::java.lang.Character._charValue19932 = @__env.GetMethodIDNoThrow(global::java.lang.Character.staticClass, "charValue", "()C");
			global::java.lang.Character._isSupplementaryCodePoint19933 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isSupplementaryCodePoint", "(I)Z");
			global::java.lang.Character._isSurrogatePair19934 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isSurrogatePair", "(CC)Z");
			global::java.lang.Character._toCodePoint19935 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "toCodePoint", "(CC)I");
			global::java.lang.Character._isLowerCase19936 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isLowerCase", "(I)Z");
			global::java.lang.Character._isLowerCase19937 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isLowerCase", "(C)Z");
			global::java.lang.Character._isUpperCase19938 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isUpperCase", "(I)Z");
			global::java.lang.Character._isUpperCase19939 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isUpperCase", "(C)Z");
			global::java.lang.Character._isTitleCase19940 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isTitleCase", "(C)Z");
			global::java.lang.Character._isTitleCase19941 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isTitleCase", "(I)Z");
			global::java.lang.Character._isDigit19942 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isDigit", "(I)Z");
			global::java.lang.Character._isDigit19943 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isDigit", "(C)Z");
			global::java.lang.Character._isDefined19944 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isDefined", "(I)Z");
			global::java.lang.Character._isDefined19945 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isDefined", "(C)Z");
			global::java.lang.Character._isLetter19946 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isLetter", "(C)Z");
			global::java.lang.Character._isLetter19947 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isLetter", "(I)Z");
			global::java.lang.Character._isLetterOrDigit19948 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isLetterOrDigit", "(C)Z");
			global::java.lang.Character._isLetterOrDigit19949 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isLetterOrDigit", "(I)Z");
			global::java.lang.Character._isJavaLetter19950 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isJavaLetter", "(C)Z");
			global::java.lang.Character._isJavaLetterOrDigit19951 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isJavaLetterOrDigit", "(C)Z");
			global::java.lang.Character._isUnicodeIdentifierStart19952 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isUnicodeIdentifierStart", "(C)Z");
			global::java.lang.Character._isUnicodeIdentifierStart19953 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isUnicodeIdentifierStart", "(I)Z");
			global::java.lang.Character._isUnicodeIdentifierPart19954 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isUnicodeIdentifierPart", "(C)Z");
			global::java.lang.Character._isUnicodeIdentifierPart19955 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isUnicodeIdentifierPart", "(I)Z");
			global::java.lang.Character._isIdentifierIgnorable19956 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isIdentifierIgnorable", "(I)Z");
			global::java.lang.Character._isIdentifierIgnorable19957 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isIdentifierIgnorable", "(C)Z");
			global::java.lang.Character._toTitleCase19958 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "toTitleCase", "(C)C");
			global::java.lang.Character._toTitleCase19959 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "toTitleCase", "(I)I");
			global::java.lang.Character._digit19960 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "digit", "(CI)I");
			global::java.lang.Character._digit19961 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "digit", "(II)I");
			global::java.lang.Character._getNumericValue19962 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "getNumericValue", "(C)I");
			global::java.lang.Character._getNumericValue19963 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "getNumericValue", "(I)I");
			global::java.lang.Character._isSpace19964 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isSpace", "(C)Z");
			global::java.lang.Character._isSpaceChar19965 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isSpaceChar", "(C)Z");
			global::java.lang.Character._isSpaceChar19966 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isSpaceChar", "(I)Z");
			global::java.lang.Character._isWhitespace19967 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isWhitespace", "(I)Z");
			global::java.lang.Character._isWhitespace19968 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isWhitespace", "(C)Z");
			global::java.lang.Character._isISOControl19969 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isISOControl", "(I)Z");
			global::java.lang.Character._isISOControl19970 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isISOControl", "(C)Z");
			global::java.lang.Character._forDigit19971 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "forDigit", "(II)C");
			global::java.lang.Character._getDirectionality19972 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "getDirectionality", "(C)B");
			global::java.lang.Character._getDirectionality19973 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "getDirectionality", "(I)B");
			global::java.lang.Character._isMirrored19974 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isMirrored", "(I)Z");
			global::java.lang.Character._isMirrored19975 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isMirrored", "(C)Z");
			global::java.lang.Character._Character19976 = @__env.GetMethodIDNoThrow(global::java.lang.Character.staticClass, "<init>", "(C)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
