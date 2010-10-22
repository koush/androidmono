namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Character : java.lang.Object, java.io.Serializable, Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Character()
		{
			InitJNI();
		}
		internal Character(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Subset : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Subset()
			{
				InitJNI();
			}
			protected Subset(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _equals19647;
			public sealed override bool equals(java.lang.Object arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Character.Subset._equals19647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Character.Subset.staticClass, global::java.lang.Character.Subset._equals19647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _toString19648;
			public sealed override global::java.lang.String toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Character.Subset._toString19648)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Character.Subset.staticClass, global::java.lang.Character.Subset._toString19648)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _hashCode19649;
			public sealed override int hashCode() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Character.Subset._hashCode19649);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Character.Subset.staticClass, global::java.lang.Character.Subset._hashCode19649);
			}
			internal static global::MonoJavaBridge.MethodId _Subset19650;
			protected Subset(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Character.Subset.staticClass, global::java.lang.Character.Subset._Subset19650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.lang.Character.Subset.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Character$Subset"));
				global::java.lang.Character.Subset._equals19647 = @__env.GetMethodIDNoThrow(global::java.lang.Character.Subset.staticClass, "equals", "(Ljava/lang/Object;)Z");
				global::java.lang.Character.Subset._toString19648 = @__env.GetMethodIDNoThrow(global::java.lang.Character.Subset.staticClass, "toString", "()Ljava/lang/String;");
				global::java.lang.Character.Subset._hashCode19649 = @__env.GetMethodIDNoThrow(global::java.lang.Character.Subset.staticClass, "hashCode", "()I");
				global::java.lang.Character.Subset._Subset19650 = @__env.GetMethodIDNoThrow(global::java.lang.Character.Subset.staticClass, "<init>", "(Ljava/lang/String;)V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class UnicodeBlock : java.lang.Character.Subset
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static UnicodeBlock()
			{
				InitJNI();
			}
			internal UnicodeBlock(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _forName19651;
			public static global::java.lang.Character.UnicodeBlock forName(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.CallStaticObjectMethod(java.lang.Character.UnicodeBlock.staticClass, global::java.lang.Character.UnicodeBlock._forName19651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Character.UnicodeBlock;
			}
			internal static global::MonoJavaBridge.MethodId _of19652;
			public static global::java.lang.Character.UnicodeBlock of(char arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.CallStaticObjectMethod(java.lang.Character.UnicodeBlock.staticClass, global::java.lang.Character.UnicodeBlock._of19652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Character.UnicodeBlock;
			}
			internal static global::MonoJavaBridge.MethodId _of19653;
			public static global::java.lang.Character.UnicodeBlock of(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.CallStaticObjectMethod(java.lang.Character.UnicodeBlock.staticClass, global::java.lang.Character.UnicodeBlock._of19653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Character.UnicodeBlock;
			}
			internal static global::MonoJavaBridge.FieldId _BASIC_LATIN19654;
			public static global::java.lang.Character.UnicodeBlock BASIC_LATIN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _BASIC_LATIN19654)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LATIN_1_SUPPLEMENT19655;
			public static global::java.lang.Character.UnicodeBlock LATIN_1_SUPPLEMENT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _LATIN_1_SUPPLEMENT19655)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LATIN_EXTENDED_A19656;
			public static global::java.lang.Character.UnicodeBlock LATIN_EXTENDED_A
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _LATIN_EXTENDED_A19656)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LATIN_EXTENDED_B19657;
			public static global::java.lang.Character.UnicodeBlock LATIN_EXTENDED_B
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _LATIN_EXTENDED_B19657)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _IPA_EXTENSIONS19658;
			public static global::java.lang.Character.UnicodeBlock IPA_EXTENSIONS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _IPA_EXTENSIONS19658)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SPACING_MODIFIER_LETTERS19659;
			public static global::java.lang.Character.UnicodeBlock SPACING_MODIFIER_LETTERS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _SPACING_MODIFIER_LETTERS19659)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _COMBINING_DIACRITICAL_MARKS19660;
			public static global::java.lang.Character.UnicodeBlock COMBINING_DIACRITICAL_MARKS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _COMBINING_DIACRITICAL_MARKS19660)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _GREEK19661;
			public static global::java.lang.Character.UnicodeBlock GREEK
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _GREEK19661)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CYRILLIC19662;
			public static global::java.lang.Character.UnicodeBlock CYRILLIC
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CYRILLIC19662)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ARMENIAN19663;
			public static global::java.lang.Character.UnicodeBlock ARMENIAN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _ARMENIAN19663)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _HEBREW19664;
			public static global::java.lang.Character.UnicodeBlock HEBREW
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _HEBREW19664)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ARABIC19665;
			public static global::java.lang.Character.UnicodeBlock ARABIC
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _ARABIC19665)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DEVANAGARI19666;
			public static global::java.lang.Character.UnicodeBlock DEVANAGARI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _DEVANAGARI19666)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _BENGALI19667;
			public static global::java.lang.Character.UnicodeBlock BENGALI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _BENGALI19667)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _GURMUKHI19668;
			public static global::java.lang.Character.UnicodeBlock GURMUKHI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _GURMUKHI19668)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _GUJARATI19669;
			public static global::java.lang.Character.UnicodeBlock GUJARATI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _GUJARATI19669)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ORIYA19670;
			public static global::java.lang.Character.UnicodeBlock ORIYA
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _ORIYA19670)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TAMIL19671;
			public static global::java.lang.Character.UnicodeBlock TAMIL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _TAMIL19671)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TELUGU19672;
			public static global::java.lang.Character.UnicodeBlock TELUGU
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _TELUGU19672)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _KANNADA19673;
			public static global::java.lang.Character.UnicodeBlock KANNADA
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _KANNADA19673)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MALAYALAM19674;
			public static global::java.lang.Character.UnicodeBlock MALAYALAM
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _MALAYALAM19674)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _THAI19675;
			public static global::java.lang.Character.UnicodeBlock THAI
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _THAI19675)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LAO19676;
			public static global::java.lang.Character.UnicodeBlock LAO
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _LAO19676)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TIBETAN19677;
			public static global::java.lang.Character.UnicodeBlock TIBETAN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _TIBETAN19677)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _GEORGIAN19678;
			public static global::java.lang.Character.UnicodeBlock GEORGIAN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _GEORGIAN19678)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _HANGUL_JAMO19679;
			public static global::java.lang.Character.UnicodeBlock HANGUL_JAMO
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _HANGUL_JAMO19679)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LATIN_EXTENDED_ADDITIONAL19680;
			public static global::java.lang.Character.UnicodeBlock LATIN_EXTENDED_ADDITIONAL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _LATIN_EXTENDED_ADDITIONAL19680)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _GREEK_EXTENDED19681;
			public static global::java.lang.Character.UnicodeBlock GREEK_EXTENDED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _GREEK_EXTENDED19681)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _GENERAL_PUNCTUATION19682;
			public static global::java.lang.Character.UnicodeBlock GENERAL_PUNCTUATION
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _GENERAL_PUNCTUATION19682)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SUPERSCRIPTS_AND_SUBSCRIPTS19683;
			public static global::java.lang.Character.UnicodeBlock SUPERSCRIPTS_AND_SUBSCRIPTS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _SUPERSCRIPTS_AND_SUBSCRIPTS19683)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CURRENCY_SYMBOLS19684;
			public static global::java.lang.Character.UnicodeBlock CURRENCY_SYMBOLS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CURRENCY_SYMBOLS19684)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _COMBINING_MARKS_FOR_SYMBOLS19685;
			public static global::java.lang.Character.UnicodeBlock COMBINING_MARKS_FOR_SYMBOLS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _COMBINING_MARKS_FOR_SYMBOLS19685)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LETTERLIKE_SYMBOLS19686;
			public static global::java.lang.Character.UnicodeBlock LETTERLIKE_SYMBOLS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _LETTERLIKE_SYMBOLS19686)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _NUMBER_FORMS19687;
			public static global::java.lang.Character.UnicodeBlock NUMBER_FORMS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _NUMBER_FORMS19687)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ARROWS19688;
			public static global::java.lang.Character.UnicodeBlock ARROWS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _ARROWS19688)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MATHEMATICAL_OPERATORS19689;
			public static global::java.lang.Character.UnicodeBlock MATHEMATICAL_OPERATORS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _MATHEMATICAL_OPERATORS19689)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MISCELLANEOUS_TECHNICAL19690;
			public static global::java.lang.Character.UnicodeBlock MISCELLANEOUS_TECHNICAL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _MISCELLANEOUS_TECHNICAL19690)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CONTROL_PICTURES19691;
			public static global::java.lang.Character.UnicodeBlock CONTROL_PICTURES
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CONTROL_PICTURES19691)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _OPTICAL_CHARACTER_RECOGNITION19692;
			public static global::java.lang.Character.UnicodeBlock OPTICAL_CHARACTER_RECOGNITION
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _OPTICAL_CHARACTER_RECOGNITION19692)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ENCLOSED_ALPHANUMERICS19693;
			public static global::java.lang.Character.UnicodeBlock ENCLOSED_ALPHANUMERICS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _ENCLOSED_ALPHANUMERICS19693)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _BOX_DRAWING19694;
			public static global::java.lang.Character.UnicodeBlock BOX_DRAWING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _BOX_DRAWING19694)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _BLOCK_ELEMENTS19695;
			public static global::java.lang.Character.UnicodeBlock BLOCK_ELEMENTS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _BLOCK_ELEMENTS19695)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _GEOMETRIC_SHAPES19696;
			public static global::java.lang.Character.UnicodeBlock GEOMETRIC_SHAPES
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _GEOMETRIC_SHAPES19696)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MISCELLANEOUS_SYMBOLS19697;
			public static global::java.lang.Character.UnicodeBlock MISCELLANEOUS_SYMBOLS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _MISCELLANEOUS_SYMBOLS19697)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DINGBATS19698;
			public static global::java.lang.Character.UnicodeBlock DINGBATS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _DINGBATS19698)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CJK_SYMBOLS_AND_PUNCTUATION19699;
			public static global::java.lang.Character.UnicodeBlock CJK_SYMBOLS_AND_PUNCTUATION
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CJK_SYMBOLS_AND_PUNCTUATION19699)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _HIRAGANA19700;
			public static global::java.lang.Character.UnicodeBlock HIRAGANA
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _HIRAGANA19700)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _KATAKANA19701;
			public static global::java.lang.Character.UnicodeBlock KATAKANA
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _KATAKANA19701)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _BOPOMOFO19702;
			public static global::java.lang.Character.UnicodeBlock BOPOMOFO
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _BOPOMOFO19702)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _HANGUL_COMPATIBILITY_JAMO19703;
			public static global::java.lang.Character.UnicodeBlock HANGUL_COMPATIBILITY_JAMO
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _HANGUL_COMPATIBILITY_JAMO19703)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _KANBUN19704;
			public static global::java.lang.Character.UnicodeBlock KANBUN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _KANBUN19704)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ENCLOSED_CJK_LETTERS_AND_MONTHS19705;
			public static global::java.lang.Character.UnicodeBlock ENCLOSED_CJK_LETTERS_AND_MONTHS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _ENCLOSED_CJK_LETTERS_AND_MONTHS19705)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CJK_COMPATIBILITY19706;
			public static global::java.lang.Character.UnicodeBlock CJK_COMPATIBILITY
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CJK_COMPATIBILITY19706)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CJK_UNIFIED_IDEOGRAPHS19707;
			public static global::java.lang.Character.UnicodeBlock CJK_UNIFIED_IDEOGRAPHS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CJK_UNIFIED_IDEOGRAPHS19707)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _HANGUL_SYLLABLES19708;
			public static global::java.lang.Character.UnicodeBlock HANGUL_SYLLABLES
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _HANGUL_SYLLABLES19708)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _PRIVATE_USE_AREA19709;
			public static global::java.lang.Character.UnicodeBlock PRIVATE_USE_AREA
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _PRIVATE_USE_AREA19709)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CJK_COMPATIBILITY_IDEOGRAPHS19710;
			public static global::java.lang.Character.UnicodeBlock CJK_COMPATIBILITY_IDEOGRAPHS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CJK_COMPATIBILITY_IDEOGRAPHS19710)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ALPHABETIC_PRESENTATION_FORMS19711;
			public static global::java.lang.Character.UnicodeBlock ALPHABETIC_PRESENTATION_FORMS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _ALPHABETIC_PRESENTATION_FORMS19711)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ARABIC_PRESENTATION_FORMS_A19712;
			public static global::java.lang.Character.UnicodeBlock ARABIC_PRESENTATION_FORMS_A
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _ARABIC_PRESENTATION_FORMS_A19712)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _COMBINING_HALF_MARKS19713;
			public static global::java.lang.Character.UnicodeBlock COMBINING_HALF_MARKS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _COMBINING_HALF_MARKS19713)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CJK_COMPATIBILITY_FORMS19714;
			public static global::java.lang.Character.UnicodeBlock CJK_COMPATIBILITY_FORMS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CJK_COMPATIBILITY_FORMS19714)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SMALL_FORM_VARIANTS19715;
			public static global::java.lang.Character.UnicodeBlock SMALL_FORM_VARIANTS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _SMALL_FORM_VARIANTS19715)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ARABIC_PRESENTATION_FORMS_B19716;
			public static global::java.lang.Character.UnicodeBlock ARABIC_PRESENTATION_FORMS_B
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _ARABIC_PRESENTATION_FORMS_B19716)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _HALFWIDTH_AND_FULLWIDTH_FORMS19717;
			public static global::java.lang.Character.UnicodeBlock HALFWIDTH_AND_FULLWIDTH_FORMS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _HALFWIDTH_AND_FULLWIDTH_FORMS19717)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SPECIALS19718;
			public static global::java.lang.Character.UnicodeBlock SPECIALS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _SPECIALS19718)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SURROGATES_AREA19719;
			public static global::java.lang.Character.UnicodeBlock SURROGATES_AREA
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _SURROGATES_AREA19719)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SYRIAC19720;
			public static global::java.lang.Character.UnicodeBlock SYRIAC
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _SYRIAC19720)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _THAANA19721;
			public static global::java.lang.Character.UnicodeBlock THAANA
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _THAANA19721)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SINHALA19722;
			public static global::java.lang.Character.UnicodeBlock SINHALA
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _SINHALA19722)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MYANMAR19723;
			public static global::java.lang.Character.UnicodeBlock MYANMAR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _MYANMAR19723)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ETHIOPIC19724;
			public static global::java.lang.Character.UnicodeBlock ETHIOPIC
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _ETHIOPIC19724)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CHEROKEE19725;
			public static global::java.lang.Character.UnicodeBlock CHEROKEE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CHEROKEE19725)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _UNIFIED_CANADIAN_ABORIGINAL_SYLLABICS19726;
			public static global::java.lang.Character.UnicodeBlock UNIFIED_CANADIAN_ABORIGINAL_SYLLABICS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _UNIFIED_CANADIAN_ABORIGINAL_SYLLABICS19726)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _OGHAM19727;
			public static global::java.lang.Character.UnicodeBlock OGHAM
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _OGHAM19727)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _RUNIC19728;
			public static global::java.lang.Character.UnicodeBlock RUNIC
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _RUNIC19728)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _KHMER19729;
			public static global::java.lang.Character.UnicodeBlock KHMER
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _KHMER19729)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MONGOLIAN19730;
			public static global::java.lang.Character.UnicodeBlock MONGOLIAN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _MONGOLIAN19730)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _BRAILLE_PATTERNS19731;
			public static global::java.lang.Character.UnicodeBlock BRAILLE_PATTERNS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _BRAILLE_PATTERNS19731)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CJK_RADICALS_SUPPLEMENT19732;
			public static global::java.lang.Character.UnicodeBlock CJK_RADICALS_SUPPLEMENT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CJK_RADICALS_SUPPLEMENT19732)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _KANGXI_RADICALS19733;
			public static global::java.lang.Character.UnicodeBlock KANGXI_RADICALS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _KANGXI_RADICALS19733)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _IDEOGRAPHIC_DESCRIPTION_CHARACTERS19734;
			public static global::java.lang.Character.UnicodeBlock IDEOGRAPHIC_DESCRIPTION_CHARACTERS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _IDEOGRAPHIC_DESCRIPTION_CHARACTERS19734)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _BOPOMOFO_EXTENDED19735;
			public static global::java.lang.Character.UnicodeBlock BOPOMOFO_EXTENDED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _BOPOMOFO_EXTENDED19735)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CJK_UNIFIED_IDEOGRAPHS_EXTENSION_A19736;
			public static global::java.lang.Character.UnicodeBlock CJK_UNIFIED_IDEOGRAPHS_EXTENSION_A
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CJK_UNIFIED_IDEOGRAPHS_EXTENSION_A19736)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _YI_SYLLABLES19737;
			public static global::java.lang.Character.UnicodeBlock YI_SYLLABLES
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _YI_SYLLABLES19737)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _YI_RADICALS19738;
			public static global::java.lang.Character.UnicodeBlock YI_RADICALS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _YI_RADICALS19738)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CYRILLIC_SUPPLEMENTARY19739;
			public static global::java.lang.Character.UnicodeBlock CYRILLIC_SUPPLEMENTARY
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CYRILLIC_SUPPLEMENTARY19739)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TAGALOG19740;
			public static global::java.lang.Character.UnicodeBlock TAGALOG
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _TAGALOG19740)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _HANUNOO19741;
			public static global::java.lang.Character.UnicodeBlock HANUNOO
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _HANUNOO19741)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _BUHID19742;
			public static global::java.lang.Character.UnicodeBlock BUHID
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _BUHID19742)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TAGBANWA19743;
			public static global::java.lang.Character.UnicodeBlock TAGBANWA
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _TAGBANWA19743)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LIMBU19744;
			public static global::java.lang.Character.UnicodeBlock LIMBU
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _LIMBU19744)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TAI_LE19745;
			public static global::java.lang.Character.UnicodeBlock TAI_LE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _TAI_LE19745)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _KHMER_SYMBOLS19746;
			public static global::java.lang.Character.UnicodeBlock KHMER_SYMBOLS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _KHMER_SYMBOLS19746)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _PHONETIC_EXTENSIONS19747;
			public static global::java.lang.Character.UnicodeBlock PHONETIC_EXTENSIONS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _PHONETIC_EXTENSIONS19747)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MISCELLANEOUS_MATHEMATICAL_SYMBOLS_A19748;
			public static global::java.lang.Character.UnicodeBlock MISCELLANEOUS_MATHEMATICAL_SYMBOLS_A
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _MISCELLANEOUS_MATHEMATICAL_SYMBOLS_A19748)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SUPPLEMENTAL_ARROWS_A19749;
			public static global::java.lang.Character.UnicodeBlock SUPPLEMENTAL_ARROWS_A
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _SUPPLEMENTAL_ARROWS_A19749)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SUPPLEMENTAL_ARROWS_B19750;
			public static global::java.lang.Character.UnicodeBlock SUPPLEMENTAL_ARROWS_B
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _SUPPLEMENTAL_ARROWS_B19750)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MISCELLANEOUS_MATHEMATICAL_SYMBOLS_B19751;
			public static global::java.lang.Character.UnicodeBlock MISCELLANEOUS_MATHEMATICAL_SYMBOLS_B
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _MISCELLANEOUS_MATHEMATICAL_SYMBOLS_B19751)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SUPPLEMENTAL_MATHEMATICAL_OPERATORS19752;
			public static global::java.lang.Character.UnicodeBlock SUPPLEMENTAL_MATHEMATICAL_OPERATORS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _SUPPLEMENTAL_MATHEMATICAL_OPERATORS19752)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MISCELLANEOUS_SYMBOLS_AND_ARROWS19753;
			public static global::java.lang.Character.UnicodeBlock MISCELLANEOUS_SYMBOLS_AND_ARROWS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _MISCELLANEOUS_SYMBOLS_AND_ARROWS19753)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _KATAKANA_PHONETIC_EXTENSIONS19754;
			public static global::java.lang.Character.UnicodeBlock KATAKANA_PHONETIC_EXTENSIONS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _KATAKANA_PHONETIC_EXTENSIONS19754)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _YIJING_HEXAGRAM_SYMBOLS19755;
			public static global::java.lang.Character.UnicodeBlock YIJING_HEXAGRAM_SYMBOLS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _YIJING_HEXAGRAM_SYMBOLS19755)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _VARIATION_SELECTORS19756;
			public static global::java.lang.Character.UnicodeBlock VARIATION_SELECTORS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _VARIATION_SELECTORS19756)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LINEAR_B_SYLLABARY19757;
			public static global::java.lang.Character.UnicodeBlock LINEAR_B_SYLLABARY
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _LINEAR_B_SYLLABARY19757)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LINEAR_B_IDEOGRAMS19758;
			public static global::java.lang.Character.UnicodeBlock LINEAR_B_IDEOGRAMS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _LINEAR_B_IDEOGRAMS19758)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _AEGEAN_NUMBERS19759;
			public static global::java.lang.Character.UnicodeBlock AEGEAN_NUMBERS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _AEGEAN_NUMBERS19759)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _OLD_ITALIC19760;
			public static global::java.lang.Character.UnicodeBlock OLD_ITALIC
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _OLD_ITALIC19760)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _GOTHIC19761;
			public static global::java.lang.Character.UnicodeBlock GOTHIC
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _GOTHIC19761)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _UGARITIC19762;
			public static global::java.lang.Character.UnicodeBlock UGARITIC
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _UGARITIC19762)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DESERET19763;
			public static global::java.lang.Character.UnicodeBlock DESERET
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _DESERET19763)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SHAVIAN19764;
			public static global::java.lang.Character.UnicodeBlock SHAVIAN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _SHAVIAN19764)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _OSMANYA19765;
			public static global::java.lang.Character.UnicodeBlock OSMANYA
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _OSMANYA19765)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CYPRIOT_SYLLABARY19766;
			public static global::java.lang.Character.UnicodeBlock CYPRIOT_SYLLABARY
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CYPRIOT_SYLLABARY19766)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _BYZANTINE_MUSICAL_SYMBOLS19767;
			public static global::java.lang.Character.UnicodeBlock BYZANTINE_MUSICAL_SYMBOLS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _BYZANTINE_MUSICAL_SYMBOLS19767)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MUSICAL_SYMBOLS19768;
			public static global::java.lang.Character.UnicodeBlock MUSICAL_SYMBOLS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _MUSICAL_SYMBOLS19768)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TAI_XUAN_JING_SYMBOLS19769;
			public static global::java.lang.Character.UnicodeBlock TAI_XUAN_JING_SYMBOLS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _TAI_XUAN_JING_SYMBOLS19769)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MATHEMATICAL_ALPHANUMERIC_SYMBOLS19770;
			public static global::java.lang.Character.UnicodeBlock MATHEMATICAL_ALPHANUMERIC_SYMBOLS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _MATHEMATICAL_ALPHANUMERIC_SYMBOLS19770)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CJK_UNIFIED_IDEOGRAPHS_EXTENSION_B19771;
			public static global::java.lang.Character.UnicodeBlock CJK_UNIFIED_IDEOGRAPHS_EXTENSION_B
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CJK_UNIFIED_IDEOGRAPHS_EXTENSION_B19771)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CJK_COMPATIBILITY_IDEOGRAPHS_SUPPLEMENT19772;
			public static global::java.lang.Character.UnicodeBlock CJK_COMPATIBILITY_IDEOGRAPHS_SUPPLEMENT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _CJK_COMPATIBILITY_IDEOGRAPHS_SUPPLEMENT19772)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TAGS19773;
			public static global::java.lang.Character.UnicodeBlock TAGS
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _TAGS19773)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _VARIATION_SELECTORS_SUPPLEMENT19774;
			public static global::java.lang.Character.UnicodeBlock VARIATION_SELECTORS_SUPPLEMENT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _VARIATION_SELECTORS_SUPPLEMENT19774)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SUPPLEMENTARY_PRIVATE_USE_AREA_A19775;
			public static global::java.lang.Character.UnicodeBlock SUPPLEMENTARY_PRIVATE_USE_AREA_A
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _SUPPLEMENTARY_PRIVATE_USE_AREA_A19775)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SUPPLEMENTARY_PRIVATE_USE_AREA_B19776;
			public static global::java.lang.Character.UnicodeBlock SUPPLEMENTARY_PRIVATE_USE_AREA_B
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _SUPPLEMENTARY_PRIVATE_USE_AREA_B19776)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _HIGH_SURROGATES19777;
			public static global::java.lang.Character.UnicodeBlock HIGH_SURROGATES
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _HIGH_SURROGATES19777)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _HIGH_PRIVATE_USE_SURROGATES19778;
			public static global::java.lang.Character.UnicodeBlock HIGH_PRIVATE_USE_SURROGATES
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _HIGH_PRIVATE_USE_SURROGATES19778)) as java.lang.Character.UnicodeBlock;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LOW_SURROGATES19779;
			public static global::java.lang.Character.UnicodeBlock LOW_SURROGATES
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character.UnicodeBlock>(@__env.GetStaticObjectField(global::java.lang.Character.UnicodeBlock.staticClass, _LOW_SURROGATES19779)) as java.lang.Character.UnicodeBlock;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.lang.Character.UnicodeBlock.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Character$UnicodeBlock"));
				global::java.lang.Character.UnicodeBlock._forName19651 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "forName", "(Ljava/lang/String;)Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._of19652 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "of", "(C)Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._of19653 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "of", "(I)Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._BASIC_LATIN19654 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "BASIC_LATIN", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._LATIN_1_SUPPLEMENT19655 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "LATIN_1_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._LATIN_EXTENDED_A19656 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "LATIN_EXTENDED_A", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._LATIN_EXTENDED_B19657 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "LATIN_EXTENDED_B", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._IPA_EXTENSIONS19658 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "IPA_EXTENSIONS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._SPACING_MODIFIER_LETTERS19659 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "SPACING_MODIFIER_LETTERS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._COMBINING_DIACRITICAL_MARKS19660 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "COMBINING_DIACRITICAL_MARKS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._GREEK19661 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "GREEK", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CYRILLIC19662 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CYRILLIC", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._ARMENIAN19663 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "ARMENIAN", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._HEBREW19664 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "HEBREW", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._ARABIC19665 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "ARABIC", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._DEVANAGARI19666 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "DEVANAGARI", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._BENGALI19667 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "BENGALI", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._GURMUKHI19668 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "GURMUKHI", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._GUJARATI19669 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "GUJARATI", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._ORIYA19670 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "ORIYA", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._TAMIL19671 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "TAMIL", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._TELUGU19672 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "TELUGU", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._KANNADA19673 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "KANNADA", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._MALAYALAM19674 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "MALAYALAM", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._THAI19675 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "THAI", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._LAO19676 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "LAO", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._TIBETAN19677 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "TIBETAN", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._GEORGIAN19678 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "GEORGIAN", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._HANGUL_JAMO19679 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "HANGUL_JAMO", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._LATIN_EXTENDED_ADDITIONAL19680 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "LATIN_EXTENDED_ADDITIONAL", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._GREEK_EXTENDED19681 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "GREEK_EXTENDED", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._GENERAL_PUNCTUATION19682 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "GENERAL_PUNCTUATION", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._SUPERSCRIPTS_AND_SUBSCRIPTS19683 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "SUPERSCRIPTS_AND_SUBSCRIPTS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CURRENCY_SYMBOLS19684 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CURRENCY_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._COMBINING_MARKS_FOR_SYMBOLS19685 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "COMBINING_MARKS_FOR_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._LETTERLIKE_SYMBOLS19686 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "LETTERLIKE_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._NUMBER_FORMS19687 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "NUMBER_FORMS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._ARROWS19688 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "ARROWS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._MATHEMATICAL_OPERATORS19689 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "MATHEMATICAL_OPERATORS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._MISCELLANEOUS_TECHNICAL19690 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "MISCELLANEOUS_TECHNICAL", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CONTROL_PICTURES19691 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CONTROL_PICTURES", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._OPTICAL_CHARACTER_RECOGNITION19692 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "OPTICAL_CHARACTER_RECOGNITION", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._ENCLOSED_ALPHANUMERICS19693 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "ENCLOSED_ALPHANUMERICS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._BOX_DRAWING19694 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "BOX_DRAWING", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._BLOCK_ELEMENTS19695 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "BLOCK_ELEMENTS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._GEOMETRIC_SHAPES19696 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "GEOMETRIC_SHAPES", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._MISCELLANEOUS_SYMBOLS19697 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "MISCELLANEOUS_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._DINGBATS19698 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "DINGBATS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CJK_SYMBOLS_AND_PUNCTUATION19699 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CJK_SYMBOLS_AND_PUNCTUATION", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._HIRAGANA19700 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "HIRAGANA", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._KATAKANA19701 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "KATAKANA", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._BOPOMOFO19702 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "BOPOMOFO", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._HANGUL_COMPATIBILITY_JAMO19703 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "HANGUL_COMPATIBILITY_JAMO", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._KANBUN19704 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "KANBUN", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._ENCLOSED_CJK_LETTERS_AND_MONTHS19705 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "ENCLOSED_CJK_LETTERS_AND_MONTHS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CJK_COMPATIBILITY19706 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CJK_COMPATIBILITY", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CJK_UNIFIED_IDEOGRAPHS19707 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CJK_UNIFIED_IDEOGRAPHS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._HANGUL_SYLLABLES19708 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "HANGUL_SYLLABLES", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._PRIVATE_USE_AREA19709 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "PRIVATE_USE_AREA", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CJK_COMPATIBILITY_IDEOGRAPHS19710 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CJK_COMPATIBILITY_IDEOGRAPHS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._ALPHABETIC_PRESENTATION_FORMS19711 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "ALPHABETIC_PRESENTATION_FORMS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._ARABIC_PRESENTATION_FORMS_A19712 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "ARABIC_PRESENTATION_FORMS_A", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._COMBINING_HALF_MARKS19713 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "COMBINING_HALF_MARKS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CJK_COMPATIBILITY_FORMS19714 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CJK_COMPATIBILITY_FORMS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._SMALL_FORM_VARIANTS19715 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "SMALL_FORM_VARIANTS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._ARABIC_PRESENTATION_FORMS_B19716 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "ARABIC_PRESENTATION_FORMS_B", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._HALFWIDTH_AND_FULLWIDTH_FORMS19717 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "HALFWIDTH_AND_FULLWIDTH_FORMS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._SPECIALS19718 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "SPECIALS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._SURROGATES_AREA19719 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "SURROGATES_AREA", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._SYRIAC19720 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "SYRIAC", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._THAANA19721 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "THAANA", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._SINHALA19722 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "SINHALA", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._MYANMAR19723 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "MYANMAR", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._ETHIOPIC19724 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "ETHIOPIC", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CHEROKEE19725 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CHEROKEE", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._UNIFIED_CANADIAN_ABORIGINAL_SYLLABICS19726 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "UNIFIED_CANADIAN_ABORIGINAL_SYLLABICS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._OGHAM19727 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "OGHAM", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._RUNIC19728 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "RUNIC", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._KHMER19729 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "KHMER", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._MONGOLIAN19730 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "MONGOLIAN", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._BRAILLE_PATTERNS19731 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "BRAILLE_PATTERNS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CJK_RADICALS_SUPPLEMENT19732 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CJK_RADICALS_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._KANGXI_RADICALS19733 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "KANGXI_RADICALS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._IDEOGRAPHIC_DESCRIPTION_CHARACTERS19734 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "IDEOGRAPHIC_DESCRIPTION_CHARACTERS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._BOPOMOFO_EXTENDED19735 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "BOPOMOFO_EXTENDED", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CJK_UNIFIED_IDEOGRAPHS_EXTENSION_A19736 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CJK_UNIFIED_IDEOGRAPHS_EXTENSION_A", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._YI_SYLLABLES19737 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "YI_SYLLABLES", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._YI_RADICALS19738 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "YI_RADICALS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CYRILLIC_SUPPLEMENTARY19739 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CYRILLIC_SUPPLEMENTARY", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._TAGALOG19740 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "TAGALOG", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._HANUNOO19741 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "HANUNOO", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._BUHID19742 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "BUHID", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._TAGBANWA19743 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "TAGBANWA", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._LIMBU19744 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "LIMBU", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._TAI_LE19745 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "TAI_LE", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._KHMER_SYMBOLS19746 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "KHMER_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._PHONETIC_EXTENSIONS19747 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "PHONETIC_EXTENSIONS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._MISCELLANEOUS_MATHEMATICAL_SYMBOLS_A19748 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "MISCELLANEOUS_MATHEMATICAL_SYMBOLS_A", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._SUPPLEMENTAL_ARROWS_A19749 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "SUPPLEMENTAL_ARROWS_A", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._SUPPLEMENTAL_ARROWS_B19750 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "SUPPLEMENTAL_ARROWS_B", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._MISCELLANEOUS_MATHEMATICAL_SYMBOLS_B19751 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "MISCELLANEOUS_MATHEMATICAL_SYMBOLS_B", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._SUPPLEMENTAL_MATHEMATICAL_OPERATORS19752 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "SUPPLEMENTAL_MATHEMATICAL_OPERATORS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._MISCELLANEOUS_SYMBOLS_AND_ARROWS19753 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "MISCELLANEOUS_SYMBOLS_AND_ARROWS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._KATAKANA_PHONETIC_EXTENSIONS19754 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "KATAKANA_PHONETIC_EXTENSIONS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._YIJING_HEXAGRAM_SYMBOLS19755 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "YIJING_HEXAGRAM_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._VARIATION_SELECTORS19756 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "VARIATION_SELECTORS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._LINEAR_B_SYLLABARY19757 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "LINEAR_B_SYLLABARY", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._LINEAR_B_IDEOGRAMS19758 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "LINEAR_B_IDEOGRAMS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._AEGEAN_NUMBERS19759 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "AEGEAN_NUMBERS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._OLD_ITALIC19760 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "OLD_ITALIC", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._GOTHIC19761 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "GOTHIC", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._UGARITIC19762 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "UGARITIC", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._DESERET19763 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "DESERET", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._SHAVIAN19764 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "SHAVIAN", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._OSMANYA19765 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "OSMANYA", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CYPRIOT_SYLLABARY19766 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CYPRIOT_SYLLABARY", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._BYZANTINE_MUSICAL_SYMBOLS19767 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "BYZANTINE_MUSICAL_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._MUSICAL_SYMBOLS19768 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "MUSICAL_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._TAI_XUAN_JING_SYMBOLS19769 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "TAI_XUAN_JING_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._MATHEMATICAL_ALPHANUMERIC_SYMBOLS19770 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "MATHEMATICAL_ALPHANUMERIC_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CJK_UNIFIED_IDEOGRAPHS_EXTENSION_B19771 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CJK_UNIFIED_IDEOGRAPHS_EXTENSION_B", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._CJK_COMPATIBILITY_IDEOGRAPHS_SUPPLEMENT19772 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "CJK_COMPATIBILITY_IDEOGRAPHS_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._TAGS19773 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "TAGS", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._VARIATION_SELECTORS_SUPPLEMENT19774 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "VARIATION_SELECTORS_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._SUPPLEMENTARY_PRIVATE_USE_AREA_A19775 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "SUPPLEMENTARY_PRIVATE_USE_AREA_A", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._SUPPLEMENTARY_PRIVATE_USE_AREA_B19776 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "SUPPLEMENTARY_PRIVATE_USE_AREA_B", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._HIGH_SURROGATES19777 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "HIGH_SURROGATES", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._HIGH_PRIVATE_USE_SURROGATES19778 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "HIGH_PRIVATE_USE_SURROGATES", "Ljava/lang/Character$UnicodeBlock;");
				global::java.lang.Character.UnicodeBlock._LOW_SURROGATES19779 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Character.UnicodeBlock.staticClass, "LOW_SURROGATES", "Ljava/lang/Character$UnicodeBlock;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _isJavaIdentifierStart19780;
		public static bool isJavaIdentifierStart(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isJavaIdentifierStart19780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isJavaIdentifierStart19781;
		public static bool isJavaIdentifierStart(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isJavaIdentifierStart19781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isJavaIdentifierPart19782;
		public static bool isJavaIdentifierPart(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isJavaIdentifierPart19782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isJavaIdentifierPart19783;
		public static bool isJavaIdentifierPart(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isJavaIdentifierPart19783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals19784;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Character._equals19784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Character.staticClass, global::java.lang.Character._equals19784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString19785;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Character._toString19785)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Character.staticClass, global::java.lang.Character._toString19785)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString19786;
		public static global::java.lang.String toString(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Character.staticClass, global::java.lang.Character._toString19786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode19787;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Character._hashCode19787);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Character.staticClass, global::java.lang.Character._hashCode19787);
		}
		internal static global::MonoJavaBridge.MethodId _reverseBytes19788;
		public static char reverseBytes(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticCharMethod(java.lang.Character.staticClass, global::java.lang.Character._reverseBytes19788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo19789;
		public int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Character._compareTo19789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Character.staticClass, global::java.lang.Character._compareTo19789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo19790;
		public int compareTo(java.lang.Character arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Character._compareTo19790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Character.staticClass, global::java.lang.Character._compareTo19790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _codePointAt19791;
		public static int codePointAt(char[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._codePointAt19791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _codePointAt19792;
		public static int codePointAt(java.lang.CharSequence arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._codePointAt19792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _codePointAt19793;
		public static int codePointAt(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._codePointAt19793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _codePointBefore19794;
		public static int codePointBefore(java.lang.CharSequence arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._codePointBefore19794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _codePointBefore19795;
		public static int codePointBefore(char[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._codePointBefore19795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _codePointBefore19796;
		public static int codePointBefore(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._codePointBefore19796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _codePointCount19797;
		public static int codePointCount(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._codePointCount19797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _codePointCount19798;
		public static int codePointCount(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._codePointCount19798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _offsetByCodePoints19799;
		public static int offsetByCodePoints(char[] arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._offsetByCodePoints19799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _offsetByCodePoints19800;
		public static int offsetByCodePoints(java.lang.CharSequence arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._offsetByCodePoints19800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _toLowerCase19801;
		public static int toLowerCase(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._toLowerCase19801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toLowerCase19802;
		public static char toLowerCase(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticCharMethod(java.lang.Character.staticClass, global::java.lang.Character._toLowerCase19802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toUpperCase19803;
		public static char toUpperCase(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticCharMethod(java.lang.Character.staticClass, global::java.lang.Character._toUpperCase19803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toUpperCase19804;
		public static int toUpperCase(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._toUpperCase19804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _valueOf19805;
		public static global::java.lang.Character valueOf(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Character>(@__env.CallStaticObjectMethod(java.lang.Character.staticClass, global::java.lang.Character._valueOf19805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Character;
		}
		internal static global::MonoJavaBridge.MethodId _toChars19806;
		public static char[] toChars(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallStaticObjectMethod(java.lang.Character.staticClass, global::java.lang.Character._toChars19806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _toChars19807;
		public static int toChars(int arg0, char[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._toChars19807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _charCount19808;
		public static int charCount(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._charCount19808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getType19809;
		public static int getType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._getType19809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getType19810;
		public static int getType(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._getType19810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isValidCodePoint19811;
		public static bool isValidCodePoint(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isValidCodePoint19811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLowSurrogate19812;
		public static bool isLowSurrogate(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isLowSurrogate19812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isHighSurrogate19813;
		public static bool isHighSurrogate(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isHighSurrogate19813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _charValue19814;
		public char charValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.lang.Character._charValue19814);
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.lang.Character.staticClass, global::java.lang.Character._charValue19814);
		}
		internal static global::MonoJavaBridge.MethodId _isSupplementaryCodePoint19815;
		public static bool isSupplementaryCodePoint(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isSupplementaryCodePoint19815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSurrogatePair19816;
		public static bool isSurrogatePair(char arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isSurrogatePair19816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _toCodePoint19817;
		public static int toCodePoint(char arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._toCodePoint19817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isLowerCase19818;
		public static bool isLowerCase(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isLowerCase19818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLowerCase19819;
		public static bool isLowerCase(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isLowerCase19819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isUpperCase19820;
		public static bool isUpperCase(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isUpperCase19820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isUpperCase19821;
		public static bool isUpperCase(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isUpperCase19821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isTitleCase19822;
		public static bool isTitleCase(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isTitleCase19822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isTitleCase19823;
		public static bool isTitleCase(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isTitleCase19823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDigit19824;
		public static bool isDigit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isDigit19824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDigit19825;
		public static bool isDigit(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isDigit19825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDefined19826;
		public static bool isDefined(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isDefined19826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDefined19827;
		public static bool isDefined(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isDefined19827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLetter19828;
		public static bool isLetter(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isLetter19828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLetter19829;
		public static bool isLetter(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isLetter19829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLetterOrDigit19830;
		public static bool isLetterOrDigit(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isLetterOrDigit19830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLetterOrDigit19831;
		public static bool isLetterOrDigit(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isLetterOrDigit19831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isJavaLetter19832;
		public static bool isJavaLetter(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isJavaLetter19832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isJavaLetterOrDigit19833;
		public static bool isJavaLetterOrDigit(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isJavaLetterOrDigit19833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isUnicodeIdentifierStart19834;
		public static bool isUnicodeIdentifierStart(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isUnicodeIdentifierStart19834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isUnicodeIdentifierStart19835;
		public static bool isUnicodeIdentifierStart(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isUnicodeIdentifierStart19835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isUnicodeIdentifierPart19836;
		public static bool isUnicodeIdentifierPart(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isUnicodeIdentifierPart19836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isUnicodeIdentifierPart19837;
		public static bool isUnicodeIdentifierPart(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isUnicodeIdentifierPart19837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isIdentifierIgnorable19838;
		public static bool isIdentifierIgnorable(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isIdentifierIgnorable19838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isIdentifierIgnorable19839;
		public static bool isIdentifierIgnorable(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isIdentifierIgnorable19839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toTitleCase19840;
		public static char toTitleCase(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticCharMethod(java.lang.Character.staticClass, global::java.lang.Character._toTitleCase19840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toTitleCase19841;
		public static int toTitleCase(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._toTitleCase19841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _digit19842;
		public static int digit(char arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._digit19842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _digit19843;
		public static int digit(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._digit19843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getNumericValue19844;
		public static int getNumericValue(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._getNumericValue19844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNumericValue19845;
		public static int getNumericValue(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.lang.Character.staticClass, global::java.lang.Character._getNumericValue19845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSpace19846;
		public static bool isSpace(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isSpace19846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSpaceChar19847;
		public static bool isSpaceChar(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isSpaceChar19847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSpaceChar19848;
		public static bool isSpaceChar(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isSpaceChar19848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isWhitespace19849;
		public static bool isWhitespace(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isWhitespace19849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isWhitespace19850;
		public static bool isWhitespace(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isWhitespace19850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isISOControl19851;
		public static bool isISOControl(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isISOControl19851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isISOControl19852;
		public static bool isISOControl(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isISOControl19852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _forDigit19853;
		public static char forDigit(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticCharMethod(java.lang.Character.staticClass, global::java.lang.Character._forDigit19853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDirectionality19854;
		public static byte getDirectionality(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticByteMethod(java.lang.Character.staticClass, global::java.lang.Character._getDirectionality19854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDirectionality19855;
		public static byte getDirectionality(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticByteMethod(java.lang.Character.staticClass, global::java.lang.Character._getDirectionality19855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isMirrored19856;
		public static bool isMirrored(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isMirrored19856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isMirrored19857;
		public static bool isMirrored(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Character.staticClass, global::java.lang.Character._isMirrored19857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Character19858;
		public Character(char arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Character.staticClass, global::java.lang.Character._Character19858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Character.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Character"));
			global::java.lang.Character._isJavaIdentifierStart19780 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isJavaIdentifierStart", "(C)Z");
			global::java.lang.Character._isJavaIdentifierStart19781 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isJavaIdentifierStart", "(I)Z");
			global::java.lang.Character._isJavaIdentifierPart19782 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isJavaIdentifierPart", "(I)Z");
			global::java.lang.Character._isJavaIdentifierPart19783 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isJavaIdentifierPart", "(C)Z");
			global::java.lang.Character._equals19784 = @__env.GetMethodIDNoThrow(global::java.lang.Character.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.Character._toString19785 = @__env.GetMethodIDNoThrow(global::java.lang.Character.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Character._toString19786 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "toString", "(C)Ljava/lang/String;");
			global::java.lang.Character._hashCode19787 = @__env.GetMethodIDNoThrow(global::java.lang.Character.staticClass, "hashCode", "()I");
			global::java.lang.Character._reverseBytes19788 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "reverseBytes", "(C)C");
			global::java.lang.Character._compareTo19789 = @__env.GetMethodIDNoThrow(global::java.lang.Character.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.lang.Character._compareTo19790 = @__env.GetMethodIDNoThrow(global::java.lang.Character.staticClass, "compareTo", "(Ljava/lang/Character;)I");
			global::java.lang.Character._codePointAt19791 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "codePointAt", "([CI)I");
			global::java.lang.Character._codePointAt19792 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "codePointAt", "(Ljava/lang/CharSequence;I)I");
			global::java.lang.Character._codePointAt19793 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "codePointAt", "([CII)I");
			global::java.lang.Character._codePointBefore19794 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "codePointBefore", "(Ljava/lang/CharSequence;I)I");
			global::java.lang.Character._codePointBefore19795 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "codePointBefore", "([CI)I");
			global::java.lang.Character._codePointBefore19796 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "codePointBefore", "([CII)I");
			global::java.lang.Character._codePointCount19797 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "codePointCount", "(Ljava/lang/CharSequence;II)I");
			global::java.lang.Character._codePointCount19798 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "codePointCount", "([CII)I");
			global::java.lang.Character._offsetByCodePoints19799 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "offsetByCodePoints", "([CIIII)I");
			global::java.lang.Character._offsetByCodePoints19800 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "offsetByCodePoints", "(Ljava/lang/CharSequence;II)I");
			global::java.lang.Character._toLowerCase19801 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "toLowerCase", "(I)I");
			global::java.lang.Character._toLowerCase19802 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "toLowerCase", "(C)C");
			global::java.lang.Character._toUpperCase19803 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "toUpperCase", "(C)C");
			global::java.lang.Character._toUpperCase19804 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "toUpperCase", "(I)I");
			global::java.lang.Character._valueOf19805 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "valueOf", "(C)Ljava/lang/Character;");
			global::java.lang.Character._toChars19806 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "toChars", "(I)[C");
			global::java.lang.Character._toChars19807 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "toChars", "(I[CI)I");
			global::java.lang.Character._charCount19808 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "charCount", "(I)I");
			global::java.lang.Character._getType19809 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "getType", "(I)I");
			global::java.lang.Character._getType19810 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "getType", "(C)I");
			global::java.lang.Character._isValidCodePoint19811 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isValidCodePoint", "(I)Z");
			global::java.lang.Character._isLowSurrogate19812 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isLowSurrogate", "(C)Z");
			global::java.lang.Character._isHighSurrogate19813 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isHighSurrogate", "(C)Z");
			global::java.lang.Character._charValue19814 = @__env.GetMethodIDNoThrow(global::java.lang.Character.staticClass, "charValue", "()C");
			global::java.lang.Character._isSupplementaryCodePoint19815 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isSupplementaryCodePoint", "(I)Z");
			global::java.lang.Character._isSurrogatePair19816 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isSurrogatePair", "(CC)Z");
			global::java.lang.Character._toCodePoint19817 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "toCodePoint", "(CC)I");
			global::java.lang.Character._isLowerCase19818 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isLowerCase", "(I)Z");
			global::java.lang.Character._isLowerCase19819 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isLowerCase", "(C)Z");
			global::java.lang.Character._isUpperCase19820 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isUpperCase", "(I)Z");
			global::java.lang.Character._isUpperCase19821 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isUpperCase", "(C)Z");
			global::java.lang.Character._isTitleCase19822 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isTitleCase", "(C)Z");
			global::java.lang.Character._isTitleCase19823 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isTitleCase", "(I)Z");
			global::java.lang.Character._isDigit19824 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isDigit", "(I)Z");
			global::java.lang.Character._isDigit19825 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isDigit", "(C)Z");
			global::java.lang.Character._isDefined19826 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isDefined", "(I)Z");
			global::java.lang.Character._isDefined19827 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isDefined", "(C)Z");
			global::java.lang.Character._isLetter19828 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isLetter", "(C)Z");
			global::java.lang.Character._isLetter19829 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isLetter", "(I)Z");
			global::java.lang.Character._isLetterOrDigit19830 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isLetterOrDigit", "(C)Z");
			global::java.lang.Character._isLetterOrDigit19831 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isLetterOrDigit", "(I)Z");
			global::java.lang.Character._isJavaLetter19832 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isJavaLetter", "(C)Z");
			global::java.lang.Character._isJavaLetterOrDigit19833 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isJavaLetterOrDigit", "(C)Z");
			global::java.lang.Character._isUnicodeIdentifierStart19834 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isUnicodeIdentifierStart", "(C)Z");
			global::java.lang.Character._isUnicodeIdentifierStart19835 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isUnicodeIdentifierStart", "(I)Z");
			global::java.lang.Character._isUnicodeIdentifierPart19836 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isUnicodeIdentifierPart", "(C)Z");
			global::java.lang.Character._isUnicodeIdentifierPart19837 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isUnicodeIdentifierPart", "(I)Z");
			global::java.lang.Character._isIdentifierIgnorable19838 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isIdentifierIgnorable", "(I)Z");
			global::java.lang.Character._isIdentifierIgnorable19839 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isIdentifierIgnorable", "(C)Z");
			global::java.lang.Character._toTitleCase19840 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "toTitleCase", "(C)C");
			global::java.lang.Character._toTitleCase19841 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "toTitleCase", "(I)I");
			global::java.lang.Character._digit19842 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "digit", "(CI)I");
			global::java.lang.Character._digit19843 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "digit", "(II)I");
			global::java.lang.Character._getNumericValue19844 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "getNumericValue", "(C)I");
			global::java.lang.Character._getNumericValue19845 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "getNumericValue", "(I)I");
			global::java.lang.Character._isSpace19846 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isSpace", "(C)Z");
			global::java.lang.Character._isSpaceChar19847 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isSpaceChar", "(C)Z");
			global::java.lang.Character._isSpaceChar19848 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isSpaceChar", "(I)Z");
			global::java.lang.Character._isWhitespace19849 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isWhitespace", "(I)Z");
			global::java.lang.Character._isWhitespace19850 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isWhitespace", "(C)Z");
			global::java.lang.Character._isISOControl19851 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isISOControl", "(I)Z");
			global::java.lang.Character._isISOControl19852 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isISOControl", "(C)Z");
			global::java.lang.Character._forDigit19853 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "forDigit", "(II)C");
			global::java.lang.Character._getDirectionality19854 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "getDirectionality", "(C)B");
			global::java.lang.Character._getDirectionality19855 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "getDirectionality", "(I)B");
			global::java.lang.Character._isMirrored19856 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isMirrored", "(I)Z");
			global::java.lang.Character._isMirrored19857 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Character.staticClass, "isMirrored", "(C)Z");
			global::java.lang.Character._Character19858 = @__env.GetMethodIDNoThrow(global::java.lang.Character.staticClass, "<init>", "(C)V");
		}
	}
}
